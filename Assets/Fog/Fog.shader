Shader "Custom/Fog"
{
	Properties
	{
		_MainTex("Source", 2D) = "white" {}
	}

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {

			Cull Off
			ZTest Always
			ZWrite Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

			#pragma multi_compile_fog
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
				float2 screenPos : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex, _CameraDepthTexture;
			//sampler2D _MainTex_ST;

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.screenPos = ComputeScreenPos(o.vertex);
				o.uv = v.uv;
				return o;
			}

            fixed4 frag (v2f i) : SV_Target
            {
				float3 sourceColor = tex2D(_MainTex, i.uv).rgb;

				#if defined(FOG_LINEAR) || defined(FOG_EXP) || defined(FOG_EXP2)
					float depth = SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, i.uv);
					depth = Linear01Depth(depth);
					float viewDistance = depth * _ProjectionParams.z- _ProjectionParams.y;

					UNITY_CALC_FOG_FACTOR_RAW(viewDistance);
					unityFogFactor = saturate(unityFogFactor);

					float3 foggedColor = lerp(unity_FogColor.rgb, sourceColor, unityFogFactor);
					return float4(foggedColor, 1);
				#else
					return float4(sourceColor, 1);
				#endif
            }
            ENDCG
        }
    }
}

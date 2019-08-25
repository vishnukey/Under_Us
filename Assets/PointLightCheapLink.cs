using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightCheapLink : MonoBehaviour
{
    [SerializeField] private Light spot;
     private Light me;


    float max;

    // Start is called before the first frame update
    void Start()
    {
        max = spot.intensity;
        me = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        me.intensity = Mathf.Clamp01((spot.intensity / max)+.4f);
    }
}

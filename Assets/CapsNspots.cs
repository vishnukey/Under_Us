using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// NOTE! This Script is also a great name for a fish and chips joint.
/// If you have an oppurtunity to make a fish and chip joint please name it this.
/// </summary>
public class CapsNspots : MonoBehaviour
{
    [SerializeField] List<Color> colors = new List<Color>();
    [MinMax(0,2, MaxLimit =2, ShowDebugValues = true)]
    [SerializeField] Vector2 emmissionRange;

    [ContextMenu("Random")]
    void Awake()
    {
        var mr = GetComponent<MeshRenderer>();
        int colorIndex = Random.Range(0, colors.Count);
        Color color = colors[colorIndex];
        mr.materials[0].color = color;
        mr.materials[0].EnableKeyword("_EMISSION");
        mr.materials[0].SetColor("_EmissionColor", color * Random.Range(emmissionRange.x, emmissionRange.y));
        transform.GetChild(0).GetComponent<Light>().color = color;
        var firstColor = colorIndex;

        while (colorIndex== firstColor)
        {
            colorIndex = (int)(Random.value * colors.Count);
        }
        color = colors[colorIndex];
        mr.materials[1].color = colors[colorIndex];
        mr.materials[1].EnableKeyword("_EMISSION");
        mr.materials[1].SetColor("_EmissionColor", color * Random.Range(emmissionRange.x, emmissionRange.y));
    }
}

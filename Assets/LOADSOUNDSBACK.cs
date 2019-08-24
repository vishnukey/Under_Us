using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LOADSOUNDSBACK : MonoBehaviour
{

    [SerializeField] private List<AudioClip> clips = new List<AudioClip>();
    [SerializeField] private GameObject fab;


    [ContextMenu("")]
    void Do()
    {
        foreach (var clip in clips)
        {
            var thing = Instantiate(fab);
            thing.transform.GetChild(0).GetComponent<AudioSource>().clip = clip;
            thing.transform.SetParent(transform);
            thing.name = clip.name;
        }
    }
}

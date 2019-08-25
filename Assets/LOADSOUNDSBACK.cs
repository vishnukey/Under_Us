using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LOADSOUNDSBACK : MonoBehaviour
{

    [SerializeField] private List<AudioClip> clips = new List<AudioClip>();
    [SerializeField] private GameObject fab;
    [SerializeField] private Transform underMe;



    void Start()
    {
        int i = 0;
        foreach (var clip in clips)
        {
            var thing = Instantiate(fab, (-Vector3.up * i), Quaternion.Euler(Vector3.zero));
            thing.name = clip.name;
            thing.transform.GetChild(0).GetComponent<AudioSource>().clip = clip;
            i++;

            thing.transform.SetParent(underMe);
        }

        //int i = 0;

        //Transform child = transform.GetChild(i);
        //while (child != null)
        //{
        //    child = transform.GetChild(i);
        //    child.localPosition = -Vector3.up * i;
        //    i++;
        //}
    }
}

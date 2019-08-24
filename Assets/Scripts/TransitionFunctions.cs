using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TransitionFunctions : Singleton<TransitionFunctions>
{
    public void Foo()
    {
        Debug.Log("Fooooo");
    }

    public void TheEnd()
    {
        Debug.Log("This is the end, my friend");
        FindObjectsOfType<InfiniScroll>().ToList().ForEach(x =>
        {
            x.off = true;
        });
    }

    public void TheFall()
    {
        FindObjectOfType<CameraLook>().GetComponentInChildren<Rigidbody>().isKinematic = false;
        FindObjectOfType<RopeScroll>().gameObject.SetActive(false);
    }
}

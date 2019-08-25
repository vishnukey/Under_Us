using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TransitionFunctions : Singleton<TransitionFunctions>
{
    public Light headLamp;
    public List<GameObject> wellWalls;

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
            FindObjectsOfType<RopeBreak>().ToList().ForEach(x => {
			x.BreakRope();
		});
    }

    public void Flicker()
    {
        LightController.Instance.Toggle();
    }

    public void LightOn()
    {
        LightController.Instance.LightOn();
        LightController.Instance.ovveride = false;
    }

    public void LighOff()
    {
        LightController.Instance.LighOff();
        LightController.Instance.ovveride = true;
    }

    public void WellOut()
    {
        wellWalls.ForEach(wall => wall.SetActive(false));
    }

    public void WellOn()
    {
        wellWalls.ForEach(wall => wall.SetActive(true));
    }

}

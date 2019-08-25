using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TransitionFunctions : Singleton<TransitionFunctions>
{
    public Light headLamp;
    public List<GameObject> wellWalls;
    public Animator flickerAnimator;

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
        flickerAnimator.SetTrigger("flicker");
    }

    public void LightsOut()
    {
        headLamp.gameObject.SetActive(false);
    }

    public void LightsOn()
    {
        headLamp.gameObject.SetActive(true);
    }

    public void WellOut()
    {
        wellWalls.ForEach(wall => wall.SetActive(false));
    }

    public void WellOn()
    {
        wellWalls.ForEach(wall => wall.SetActive(false));
    }

}

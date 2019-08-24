using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniScroll : MonoBehaviour
{
    const float BOTTOM_DEPTH_CHECK = 0;
    const float MOVE_AMNT = 12.86f;

    [SerializeField] Transform assets = null; // The assets to be scrolled up, when appropriate
    //[SerializeField] Transform player;

    bool isPastBottom => transform.position.y < BOTTOM_DEPTH_CHECK && !off;
    public bool off = false;

    // Update is called once per frame
    void Update()
    {
        // TODO: Be less clever, but keep it elegant
        if (isPastBottom)
            new List<Transform> { transform, assets } // collect all relevant Transforms together
                .ForEach(x => { if (x) moveUp(x); }); // move each tranfrom up, if it exists
    }

    void moveUp(Transform toMove)
    {
        toMove.position += MOVE_AMNT * Vector3.up;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMaker : MonoBehaviour
{
    private void Awake()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(Random.value > .5f);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : Singleton<LightController>
{
    bool on = true;
    public Animator flickerAnimator;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Toggle();
            if(!audioSource.isPlaying)
                audioSource.Play();
        }
    }

    public void Toggle()
    {
        if (on)
            flickerAnimator.SetTrigger("Off");
        else
            flickerAnimator.SetTrigger("On");

        on = !on;
    }

    public void LightOn()
    {
        if (!on)
            Toggle();
    }

    public void LighOff()
    {
        if (on)
            Toggle();
    }
}

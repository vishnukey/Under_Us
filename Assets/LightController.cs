using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : Singleton<LightController>
{
    public Animator flickerAnimator;
	public new Light light;

	private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
		light = GetComponent<Light>();
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
			light.enabled = !light.enabled;
			if(!audioSource.isPlaying)
                audioSource.Play();
        }
    }

    public void LightOn() {
		flickerAnimator.SetTrigger("On");
    }

    public void LighOff() {
		flickerAnimator.SetTrigger("Off");
    }
}

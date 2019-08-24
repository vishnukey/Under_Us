using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {
	public float sensitivity = 60f;
	float rotationY = 0.0f;
	float rotationX = 0.0f;
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		rotationX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		rotationY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
		rotationY = Mathf.Clamp(rotationY, -89.9f, 89.9f);
		transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
	}
}

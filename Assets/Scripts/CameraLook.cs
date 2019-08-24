using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {
	// Start is called before the first frame update
	float rotationY = 0.0f;
	float rotationX = 0.0f;
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		rotationX += Input.GetAxis("Mouse X") * Time.deltaTime;
		rotationY += Input.GetAxis("Mouse Y") * Time.deltaTime;
		rotationY = Mathf.Clamp(rotationY, -89.9f, 89.9f);
		transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
	}
}

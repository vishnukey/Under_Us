using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellPlayer : MonoBehaviour {
	public float climbSpeed = 1;
	float height = 0;
	void Start() {
	}

	void Update() {
		//Cursor.lockState = CursorLockMode.Locked;
		height += Input.mouseScrollDelta.y * climbSpeed;
		if (height > 0) height = 0;
		transform.localPosition = Vector3.up * height;
	}
}

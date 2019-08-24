
using UnityEngine;

public class WellPlayer : MonoBehaviour {
	public float sensitivity = 0.01f;
	public float maxSpeed = 0.1f;
	public float friction = 0.1f;
	float height = 0;
	float speed = 0;
	void Start() {
	}

	void Update() {
		//Cursor.lockState = CursorLockMode.Locked;
		speed += Input.mouseScrollDelta.y * sensitivity;
		speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
		speed *= (1 - friction);
		height += speed;
		//if (height > 0) height = 0;
		transform.localPosition = Vector3.up * height;
	}
}

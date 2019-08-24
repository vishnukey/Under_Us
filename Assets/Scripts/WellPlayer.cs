
using UnityEngine;

public class WellPlayer : MonoBehaviour {
	public float sensitivity = 0.6f;
	public float maxSpeed = 6f;
	public float friction = 0.1f;
	float height = 0;
	float speed = 0;
	Vector3 startPos;
	void Start() {
		startPos = transform.localPosition;
	}

	void FixedUpdate() {
		//Cursor.lockState = CursorLockMode.Locked;
		speed += Input.mouseScrollDelta.y * sensitivity;
		speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
		speed *= (1 - friction);
		height += speed * Time.deltaTime;
		//if (height > 0) height = 0;
		transform.localPosition = startPos + (Vector3.up * height);
	}
}


using UnityEngine;

public class WellPlayer : MonoBehaviour {
    [SerializeField] bool canScrollUp = false;
	const float epsilon = 0.0001f; // A value close enough to zero to consider it zero
	public float sensitivity = 0.6f;
	public float maxSpeed = 6f;
	public float friction = 0.1f;
	public float height { get { return _height; } }
	public float _height = 0;
	float speed = 0;
	Vector3 startPos; // !!UNUSED!!

	Material textureScroll;
	void Start() {
		startPos = transform.localPosition;
	}

	void FixedUpdate() {
		speed += Input.mouseScrollDelta.y * sensitivity;
		speed *= (1 - friction);
		speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
		speed = Mathf.Abs(speed) < epsilon ? 0 : speed; // If the speed is small enough, just set it to zero

		float delta; // amount to move this frame
		delta = speed * Time.deltaTime;
		if (Input.GetKey(KeyCode.PageUp)) delta = maxSpeed * Time.deltaTime;
		if (Input.GetKey(KeyCode.PageDown)) delta = -maxSpeed * Time.deltaTime;

        delta = canScrollUp ? delta : Mathf.Clamp(delta, -Mathf.Infinity, 0);

		_height += delta;

		transform.localPosition += (Vector3.up * delta); // move by that amount int the vertical direction
	}
}

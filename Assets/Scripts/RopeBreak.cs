using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBreak : MonoBehaviour {
	[System.Serializable]
	public struct ForceObject { public Rigidbody body; public Vector3 force; }
	public GameObject RopeRemains;
	public List<ForceObject> ropeForce;
	public Rigidbody playerRigidbody;
	public GameObject Rope;
	public void BreakRope() {

		Debug.Log("Falling");
		playerRigidbody.isKinematic = false;
		Rope.SetActive(false);
		GetComponent<Animator>().enabled = false;
		RopeRemains.SetActive(true);
		ropeForce.ForEach(fo => fo.body.AddForce(fo.force,ForceMode.Impulse));
	}
}

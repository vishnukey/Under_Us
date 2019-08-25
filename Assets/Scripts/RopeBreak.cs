using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBreak : MonoBehaviour {
	public GameObject RopeRemains;
	public Rigidbody playerRigidbody;
	public GameObject Rope;
	public void BreakRope(){

		Debug.Log("Falling");
		playerRigidbody.isKinematic = false;
		Rope.SetActive(false);
		GetComponent<Animator>().enabled = false;
		RopeRemains.SetActive(true);
	}
}

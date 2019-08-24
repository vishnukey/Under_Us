using System.Linq;
using UnityEngine;

public class RopeScroll : MonoBehaviour {
	public float scrollspeed;
	WellPlayer wellPlayer;
	Material material;
	void Start() {
		wellPlayer = GetComponentInParent<WellPlayer>();
		material = GetComponent<Renderer>().material;
	}

	// Update is called once per frame
	void Update() {
		material.mainTextureOffset = new Vector2(wellPlayer.height * scrollspeed, 0);
	}
}

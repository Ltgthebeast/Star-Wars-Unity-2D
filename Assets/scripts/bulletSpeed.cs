using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpeed : MonoBehaviour {
	public Rigidbody2D rgd;
	public Transform trans;
	public float velocity = .2f;
	// Use this for initialization
	void Start () {
		trans.Rotate (new Vector3 (0, 0, -90));
		rgd.velocity = new Vector2 (velocity, rgd.velocity.y);
	}
	
	// Update is called once per frame
	void Update () {
		if (trans.position.x > 50) {
			Destroy (this.gameObject, 0f);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour {
	public Transform trans;
	public float rate = .1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			// move up
			trans.position = new Vector2(trans.position.x, trans.position.y + rate);
		} else if (Input.GetKey (KeyCode.S)) {
			// move down
			trans.position = new Vector2(trans.position.x, trans.position.y - rate);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullet : MonoBehaviour {
	public GameObject prefab;
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Instantiate (prefab.gameObject, new Vector3(player.position.x, player.position.y, player.position.z));
		}
	}
}	

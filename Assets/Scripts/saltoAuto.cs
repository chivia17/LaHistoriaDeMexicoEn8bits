﻿using UnityEngine;
using System.Collections;

public class saltoAuto : MonoBehaviour {
	float mov;
	public static float altura;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mov = Input.acceleration.x;
		GetComponent<Rigidbody> ().AddForce (new Vector2(mov,0),ForceMode.Impulse);
		altura = transform.position.y;
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("Choqué");
		GetComponent<Rigidbody> ().AddForce (new Vector2(0,10),ForceMode.Impulse);
	}
}
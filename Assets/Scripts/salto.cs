using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {
	bool grounded=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded && Input.touches.Length > 0) {
			GetComponent<Rigidbody> ().AddForce (new Vector2 (0, 7), ForceMode.Impulse);
		}
	
	}

	void OnCollisionEnter(Collision other){
			if(other.gameObject.name.Equals("Plane")){
				grounded = true;
			}
		}

	void OnCollisionExit(Collision other){
			if(other.gameObject.name.Equals("Plane")){
				grounded = false;
			}
	}
}
using UnityEngine;
using System.Collections;

public class Avanza : MonoBehaviour {
	bool grounded=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded ) {
		GetComponent<Rigidbody> ().AddForce (new Vector2 (1,0), ForceMode.Impulse);
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

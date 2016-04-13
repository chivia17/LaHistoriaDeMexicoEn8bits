using UnityEngine;
using System.Collections;

public class Avanza : MonoBehaviour {
	bool grounded=false;
	float acl;
	int cont;
	// Use this for initialization
	void Start () {
		cont = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Rigidbody>().velocity.x< 4) {
			//acl = (Time.deltaTime / Time.realtimeSinceStartup) + Time.fixedTime * Time.deltaTime;
			acl=Time.realtimeSinceStartup*Time.deltaTime;
			GetComponent<Rigidbody> ().AddForce (new Vector2 (acl, 0), ForceMode.Impulse);
		}

		cont++;
		Debug.Log (acl);
		Debug.Log ("Velocidad: "+GetComponent<Rigidbody>().velocity);
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

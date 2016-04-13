using UnityEngine;
using System.Collections;

public class Avanza : MonoBehaviour {
	float acl;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GetComponent<Rigidbody>().velocity.x< 6) {
			//acl = (Time.deltaTime / Time.realtimeSinceStartup) + Time.fixedTime * Time.deltaTime;
			acl=Time.realtimeSinceStartup*Time.deltaTime;
			if(acl<3)
				acl=Time.realtimeSinceStartup*Time.deltaTime*3;
			GetComponent<Rigidbody> ().AddForce (new Vector2 (acl, 0), ForceMode.Impulse);

		}

		Debug.Log (acl);
		Debug.Log ("Velocidad: "+GetComponent<Rigidbody>().velocity);
	}
}
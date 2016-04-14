using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	bool groudend;

	public GameObject[] obj;
	public float tiempomin = 2f;
	public float tiempomax = 5f;
	// Use this for initialization
	void Start () {
		generar ();
		groudend = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void generar(){
		Debug.Log (transform.position);
		if (transform.position.y <= .5) {
			Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
			Invoke ("generar", Random.Range (tiempomin, tiempomax));
		} else
			Invoke ("generar", Random.Range (tiempomin, tiempomax));

	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("Soy gen");
	}
}
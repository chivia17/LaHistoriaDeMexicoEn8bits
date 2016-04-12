using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public float tiempomin = 2f;
	public float tiempomax = 4f;
	// Use this for initialization
	void Start () {
		generar ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generar(){
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke("generar", Random.Range(tiempomin,tiempomax));
}
}

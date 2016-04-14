using UnityEngine;
using System.Collections;

public class avanzaCamara : MonoBehaviour {
	float thisx;
	float aux=1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Avanza.posx);
		thisx = Avanza.posx+aux;
		GetComponent<Rigidbody> ().MovePosition (new Vector3(thisx,2,-10));
	}
}

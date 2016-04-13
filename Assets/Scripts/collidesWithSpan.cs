using UnityEngine;
using System.Collections;

public class collidesWithSpan : MonoBehaviour {
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name.Equals("EspañolCuchillo(Clone)"))
		{
			Debug.Log ("Perdiste");
		}
	}
}

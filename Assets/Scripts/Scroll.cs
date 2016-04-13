using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	public Renderer rend ;
	public float velocidad =  0.4f;
	void Start () {
		rend = GetComponent <Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.mainTextureOffset = new Vector2 (Time.time * velocidad,0f);
	}
}

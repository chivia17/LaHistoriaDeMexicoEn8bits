﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EspañolGameOver : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		
		if (other.gameObject.name.Equals ("Caballo1")) {
			SceneManager.LoadScene (0);
		}
	}
}

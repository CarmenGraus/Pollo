﻿using UnityEngine;
using System.Collections;

public class Palo : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Entrando");
	}
	
	void OnTriggerExit2D(Collider2D other){
		Debug.Log ("Saliendo");
	}
	
	void OnTriggerStay2D(Collider2D other){
		Debug.Log ("Dentro");
	}
	
}

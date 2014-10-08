using UnityEngine;
using System.Collections;

public class asteroide : MonoBehaviour { 
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("c"))
			caeasteroide();
		}
	void caeasteroide(){
		rigidbody2D.gravityScale = 1;
	}
}
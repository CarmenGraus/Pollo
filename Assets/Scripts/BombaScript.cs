using UnityEngine;
using System.Collections;

public class BombaScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Se ha chocado con la bomba");
	}
}
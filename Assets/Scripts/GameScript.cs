using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Salir () {
		Application.Quit ();
	}
		public void Reiniciar (){
			Application.LoadLevel ("menu");
}
	public void Iniciar () {
		Application.LoadLevel ("nivel1");
	}
}
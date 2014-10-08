using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {
	public int jumpForce = 200; //fuerza de salto
	public int moveForce = 100; //fuerza horizontal al mover
	public int maxSpeed = 50;   //velocidad maxima del movimiento
	private bool estaherido = false;
	public AudioClip sonidoVolar;
	public AudioClip sonidoHerido;
	public AudioClip sonidoCurado;
	//Para añadir audio aqui escribido public Audioclip sonidoVolar... y luego en void saltar ponemos AudioClip.
	//Esto es necesario para poder manejar las animaciones
	Animator animation;

	void Start() {
	    //Al inicializar cargamos las variables de las animaciones
		animation = GetComponent <Animator> ();
	}
	

	void Update () {
		if (Input.GetButtonDown ("Jump")) //cuando pulsamos espacio salta
			saltar ();// mas abajo esta la funcion explicada
				
		if (Input.GetKey ("a"))
			mover (moveForce * -1);//multiplicamos por -1 para ir a la izquierda
		transform.localScale = new Vector3 (-1, 1, 1);
		if (Input.GetKey ("d"))
			mover (moveForce);
		transform.localScale = new Vector3 (1, 1, 1);
	}
	/*Funcion saltar
	 * esta funcion aplica una fuerza hacia arriba definida por la variable jumpForce
	 * ToDo: Falta animacion de salto y sonido
	 */
	 void saltar(){
		if(!estaherido)
		//Aplicamos una fuerza con rigidbody2d.AddForce
		rigidbody2D.AddForce(new Vector2 (0,jumpForce));
		animation.SetBool ("Fly", true);
		//new vector(0,jumpforce) es un vector con la x en cero y la ya jumpforce
  }
	/*Funcion mover
	 * Parametros: fuerza-> Fuerza que le vamos a aplicar para mover
	 * Aplicamos una fuerza horizontal teniendo en cuenta no sobrepasar la velocidad maxima
	 */
	void mover (int fuerza){
		//creamos una variable para guardar la velicidad actual
		float velocity = rigidbody2D.velocity.x;
		//Mathf.Abs() nos devuelve el valor absoluto de una variable
		//si hacemos  Mathf.Abs(-10) nos devuelve 10
		//si hacemos  Mathf.Abs(-30) nos devuelve 30
				if (Mathf.Abs (velocity) < maxSpeed)
			//si la velocidad absoluta es menos de maxSpeed
			//aplicamos una fuerza horizontal
				rigidbody2D.AddForce (Vector2.right * fuerza);
		}
	

	void damage() {
		estaherido = true;
		animation.SetBool ("Damage", true);


		}

	void OnCollisionEnter2D(Collision2D coll) {
		animation.SetBool ("Fly", false);
		if (coll.gameObject.tag == "Enemy")
						damage() ;
		if (coll.gameObject.tag == "sombrero")
		    curar ();
		   
	}

		    void curar (){
			estaherido = false;
			animation.SetBool ("Damage", false);
		}

 }
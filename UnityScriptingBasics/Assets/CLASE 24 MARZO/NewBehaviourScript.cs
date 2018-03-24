using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Unity lo ejecuta cada vez que empieza el playback. Solo se ejectuta 1 vez al principio
		//void Start es una funcion, metodo o procedimiento
		print ("One Shot"); //print solo funciona para escribir cosas en la consola


	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0f, 0f, -1f);
		//Lo ejecuta despues de hacer todo lo de Start. Es un ciclo que se renueva durante todo el juego. 

		//Variable de tipo bool (solo puede ser verdadera o falsa) que la relaciona con la tecla de flecha hacia la derecha
		bool isRightPressed = Input.GetKey (KeyCode.RightArrow); //click izq=0  click derecho=1  click medio=2
		print (isRightPressed); //Para que se vea en la consola

		//Para que se mueva a la derecha
		if (isRightPressed) {
			this.transform.Translate (-1, 0, 0);
		}
		//Para la IZQUIERDAAAA!!! 
		bool isLeftPressed = Input.GetKey (KeyCode.LeftArrow);
		if (isLeftPressed) {
			this.transform.Translate (1, 0, 0);
		}

		//Para arriba
		bool isUpPressed = Input.GetKey (KeyCode.UpArrow);
		if (isUpPressed) {
			this.transform.Translate (0, 1, 0);
		}

		//Para abajo
		bool isDownPressed = Input.GetKey (KeyCode.DownArrow);
		if (isDownPressed) {
			this.transform.Translate (0, -1, 0);
		}

		//Rotacion para la IZQUIERDAAAA
		bool isZPressed = Input.GetKey (KeyCode.Z);
		if (isZPressed) {
			this.transform.Rotate (0f, -0.5f, 0f);
		}
		//Rotacion para la derecha
		bool isXPressed = Input.GetKey (KeyCode.X);
		if (isXPressed) {
			this.transform.Rotate (0f, 0.5f, 0f);
		}
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	void Start () {
		
		/*DESDE AQUI ES LO QUE HICIMOS EN CLASE
		 * //importante: este script solo sirve si el game object Console est[a activado en unity
		//Pos para que sirva descomentar las instrucciones de aui abajo y hacer comentarios de las otras
		Debug.Log ("BUENAS"); //aparece en la window "consola"
		print ("buenas otra vez!"); //print hace lo mismo que Degug.log

		Debug.LogWarning ("Oh no!");//aparece con el icono de advertencia
		Debug.LogError ("No sirve D:");//aparece con el icono rojo de error
		*/




		// Impresion de Info en consola
        Debug.Log("Este texto será mostrado en la consola, es muy util!");
        print("Este texto también será impreso...");

        // Impresion de un Warning en consola
        Debug.LogWarning("Ha sucedido un una situacion no esperada");

        // Impresion de un Error en consola
        Debug.LogError("Ha sucedido un error");

        // Impresion del contenido de una variable
		//Pos saber que valor tiene la variable 
        int edad = 25;
        print("Mi edad es " + edad);

        Vector3 ubicacion = Vector3.right;
        print("Mi ubicación es " + ubicacion);
        
	}
}
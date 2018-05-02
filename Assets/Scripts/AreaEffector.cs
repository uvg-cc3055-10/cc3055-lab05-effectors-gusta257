using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * Gustavo De Leon 17085
 * Clase donde maneja la creacion de linea donde se une una linea con el peso
*/
public class AreaEffector : MonoBehaviour {
    public float time;
    public bool  estado;
    public GameObject areaeffector;

	// Use this for initialization
	void Start () {

        estado = false;
        time = 0;

        
		
	}
	
	// Update is called once per frame
	void Update () {

        time = time + Time.deltaTime;
        /*If para control de particulas y objeto con el tiempo*/
        if (time > 5)
        {
            areaeffector.SetActive(estado);
            time = 0;
            estado = !estado;            
        }
        else
        {
            gameObject.SetActive(true);
            
        }

    }

    
}

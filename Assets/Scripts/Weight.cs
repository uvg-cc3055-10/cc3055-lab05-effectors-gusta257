using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * Gustavo De Leon 17085
 * Clase donde maneja la creacion de linea donde se une una linea con el peso
*/
public class Weight : MonoBehaviour {
    public LineRenderer line;
    public DistanceJoint2D distanceJoint;

	// Use this for initialization
	void Start () {
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        /*Crea una linea donde se une el peso al suelo */
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);


    }
}

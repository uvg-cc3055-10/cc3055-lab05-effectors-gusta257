using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {

    // Use this for initialization
    void startGame()
    {
        
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    /*
     *  Pasa de escena a otra 
     *
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Dungeon2", LoadSceneMode.Single);
    }

}

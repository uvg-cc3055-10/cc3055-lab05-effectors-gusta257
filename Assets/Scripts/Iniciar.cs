using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {

    // Use this for initialization
    void startGame()
    {
        //Al presionar el boton "Play", se va a cargar la Scene "Principal" y va a iniciar el juego.
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Dungeon2", LoadSceneMode.Single);
    }

}

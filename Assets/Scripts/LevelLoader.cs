using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour {
    public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Cuando entra en el colisionador se carga el siguiente nivel. 
    //El nombre del nivel se guarda en la variable levelToLoad.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string newGameScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Loads first scene of game
    public void PlayGame(){
        SceneManager.LoadScene(newGameScene);
    }

    // Quit button functionality
    public void QuitGame(){
        Application.Quit();
    }
}

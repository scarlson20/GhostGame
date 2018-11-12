using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{

    public string levelToLoad;
    public string exitPoint;
    private SFXManager sfxMan;

    private GhostController myPlayer;

    // Use this for initialization
    void Start()
    {
        myPlayer = FindObjectOfType<GhostController>();
        sfxMan = FindObjectOfType<SFXManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Loads new scene when ghost collides with current area exit zone
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ghost")
        {
            SceneManager.LoadScene(levelToLoad);
            myPlayer.startPoint = exitPoint;
            sfxMan.changeScene.Play();
        }
    }
}

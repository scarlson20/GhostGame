using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;
	public string exitPoint;

	private GhostController myPlayer;

	// Use this for initialization
	void Start () {
		myPlayer = FindObjectOfType<GhostController> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Ghost"){
			Application.LoadLevel(levelToLoad);
			myPlayer.startPoint = exitPoint;
		}
	}
}

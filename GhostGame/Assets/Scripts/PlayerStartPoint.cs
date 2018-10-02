using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	private GhostController myPlayer;
	private CameraController myCamera;
	public Vector2 startDirection;
	public string pointName;
	// Use this for initialization
	void Start () {
		myPlayer = FindObjectOfType<GhostController> ();

		if (myPlayer.startPoint == pointName) {
			
			myPlayer.transform.position = transform.position;
			myPlayer.lastMove = startDirection;

			myCamera = FindObjectOfType<CameraController> ();
			myCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, myCamera.transform.position.z);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

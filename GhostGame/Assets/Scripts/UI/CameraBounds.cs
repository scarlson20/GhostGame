using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour {

    private BoxCollider2D bounds;
    private CameraController theCamera;


    // Use this for initialization
    // Gives camera boundaries within map area
	void Start () {
        bounds = GetComponent<BoxCollider2D>();
        theCamera = FindObjectOfType<CameraController>();
        theCamera.SetBounds(bounds);
	}
	
}

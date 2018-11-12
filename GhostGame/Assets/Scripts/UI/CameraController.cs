using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform ghost;

    public float offsetX;
    public float offsetY;
	private static bool cameraExists;

    //variables to keep camera in bounds
    public BoxCollider2D boundsBox;
    private Vector3 minBounds;
    private Vector3 maxBounds;
    private Camera theCamera;
    private float halfHeight;
    private float halfWidth;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// This was taken from FlappyChicken and modified
    /// </summary>
	/// 
	void Start() {
        // Keep one camera throughout scenes
		if (!cameraExists) {
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}

        // Set boundaries for camera to not leave map area
        minBounds = boundsBox.bounds.min;
        maxBounds = boundsBox.bounds.max;

        theCamera = GetComponent<Camera>();
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
	}

    void Update()
    {
        // Have the camera follow the ghost
        Vector3 pos = transform.position;
        pos.x = ghost.position.x + offsetX;
        pos.y = ghost.position.y + offsetY;
        transform.position = pos;

        // Keep camera within map boundary
        if(boundsBox == null){
            boundsBox = GetComponent<BoxCollider2D>();

        }

        float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
        float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }

    //resets bounds when you move to new area
    public void SetBounds(BoxCollider2D newBounds){
        boundsBox = newBounds;
        minBounds = boundsBox.bounds.min;
        maxBounds = boundsBox.bounds.max;
    }

}

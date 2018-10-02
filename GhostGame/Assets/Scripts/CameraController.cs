using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform ghost;

    public float offsetX;
    public float offsetY;
	private static bool cameraExists;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// This was taken from FlappyChicken and modified
    /// </summary>
	/// 
	void Start() {
		if (!cameraExists) {
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}

    void Update()
    {
        if ((transform.position.x - ghost.position.x != offsetX) || (transform.position.y - ghost.position.y != offsetY))
        {
            Vector3 pos = transform.position;
            pos.x = ghost.position.x + offsetX;
            pos.y = ghost.position.y + offsetY;
            transform.position = pos;
        }
    }


}

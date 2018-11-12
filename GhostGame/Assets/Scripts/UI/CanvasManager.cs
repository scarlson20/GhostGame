using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    public GameObject ourCanvas;

    //keeps single canvas throughout scenes
	void Awake() {
        DontDestroyOnLoad(ourCanvas);
	}
}

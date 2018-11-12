using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

	private DialogueManager dMan;

	public string[] dialogueLines;
    public string[] characterNames;
    public string item;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // When ghost is within area of interactable, use space to interact
	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name == "Ghost") {
			if (Input.GetKeyUp (KeyCode.Space)) {
                if (!dMan.dialogueActive)
                   {
                       dMan.dialogueLines = dialogueLines;
                       dMan.characterNames = characterNames;
                       dMan.currentLine = 0;
                   }	
                 dMan.ShowDialogue ();
			}
		}
	}
}

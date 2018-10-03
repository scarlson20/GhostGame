using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public bool dialogueActive;

	public string[] dialogueLines;
	public int currentLine;

	private GhostController myGhost;

	// Use this for initialization
	void Start () {
		myGhost = FindObjectOfType<GhostController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogueActive && Input.GetKeyDown (KeyCode.Space)) {
			//dBox.SetActive (false);
			//dialogueActive = false;

			currentLine++;
		}

		if (currentLine >= dialogueLines.Length) {
			dBox.SetActive (false);
			dialogueActive = false;
			currentLine = 0;
			myGhost.canMove = true;
		}

		dText.text = dialogueLines [currentLine];
	}

	public void ShowBox(string dialogue) {
		dialogueActive = true;
		dBox.SetActive (true);
		dText.text = dialogue;
	}

	public void ShowDialogue() {
		dialogueActive = true;
		dBox.SetActive (true);
		myGhost.canMove = false;
	}
}

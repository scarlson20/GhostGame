using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
    public Text dCharacter;

    public string[] dialogueLines;
    public string[] characterNames;
    public int currentLine;

    // Used to prevent ghost from moving when dialogue is present
    private GhostController myGhost;
    public bool dialogueActive;


	// Use this for initialization
	void Start () {
		myGhost = FindObjectOfType<GhostController> ();
	}
	
	// Update is called once per frame
	void Update () {
        // Moves to next line of dialogue
		if (dialogueActive && Input.GetKeyDown (KeyCode.Space)) {
			currentLine++;
		}

        // Deactivate dialogue box when conversation has finished
		if (currentLine >= dialogueLines.Length) {
			dBox.SetActive (false);
			dialogueActive = false;
			currentLine = 0;
			myGhost.canMove = true;
		}
        // Set to current line of dialogue
		dText.text = dialogueLines [currentLine];
        dCharacter.text = characterNames[currentLine];
	}

	public void ShowDialogue() {
		dialogueActive = true;
		dBox.SetActive (true);
		myGhost.canMove = false;
	}
}

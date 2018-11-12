using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionHolder : MonoBehaviour{

    private DialogueManager dMan;

    public string[] instructionLines;
    public string[] characterNames;
    private bool readInstructions;

    // Use this for initialization
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        readInstructions = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    // When ghost is in trigger area an instruction box will pop up
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Ghost")
        {
            if (!dMan.dialogueActive && readInstructions == false)
            {
                dMan.dialogueLines = instructionLines;
                dMan.characterNames = characterNames;
                dMan.currentLine = 0;
                dMan.ShowDialogue();
                readInstructions = true;

            }
        }
    }
}

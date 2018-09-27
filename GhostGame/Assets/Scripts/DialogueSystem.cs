using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

    private Queue<string> sentences;

    public Text dialogueText;

    // Use this for initialization
	void Start () {
        sentences = new Queue<string>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartDialogue (Dialogue dialogue) {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
}

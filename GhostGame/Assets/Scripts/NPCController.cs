using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{

    public GameObject ghost;
    public float distanceGhost;
    public Dialogue dialogue;

    // Use this for initialization
    void Start()
    {

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueSystem>().StartDialogue(dialogue);
    }

    // Update is called once per frame
    void Update()
    {
        distanceGhost = Vector2.Distance(ghost.transform.position, transform.position);
        if (distanceGhost <= 0.5 && Input.GetKeyDown(KeyCode.Return))
        {
            TriggerDialogue();
        }


    }
}
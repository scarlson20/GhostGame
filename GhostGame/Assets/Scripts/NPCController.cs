using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{

    public GameObject ghost;
    public float distanceGhost;
    public TextAsset textFile;
    public string[] dialogue;
    private int index = 0;
    public GameObject dialogueRect;
    public bool showGUI = false;

    // Use this for initialization
    void Start()
    {
        if (textFile != null)
        {
            dialogue = (textFile.text.Split('\n'));
        }
    }

    // Update is called once per frame
    void Update()
    {
        distanceGhost = Vector2.Distance(ghost.transform.position, transform.position);
        if (distanceGhost <= 55 && Input.GetKeyDown(KeyCode.Return))
        {
            OnGUI();
        }

    }
    void OnGUI()
    {
        if (showGUI == false)
        {
            //make visibilty of panel change
            //put dialogue[index] onto panel
            showGUI = !showGUI;
            index++;
        }
        else
        {
            showGUI = !showGUI;
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPCController : MonoBehaviour
{

    public GameObject ghost;
    public float distanceGhost;
    public TextAsset textFile;
    public string[] dialogue;
    private int index = 0;
    public GameObject dialogueRect;
    [SerializeField] Text dialogueTextBox;
    [SerializeField] Image textBubble;

    // Use this for initialization
    void Start()
    {
        if (textFile != null)
        {
            dialogue = (textFile.text.Split('\n'));
        }
        textBubble.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        distanceGhost = Vector2.Distance(ghost.transform.position, transform.position);
        if (distanceGhost <= 100 && Input.GetKeyDown(KeyCode.Return))
        {
            if (dialogue != null) {
                StartCoroutine(DialogueRoutine());
            }
            textBubble.enabled = false;
        }

    }
    IEnumerator DialogueRoutine()
    {

        while (index < dialogue.Length)
        {
            textBubble.enabled = true;
            dialogueTextBox.text = dialogue[index].ToString();
            yield return new WaitForSeconds(3);
            index++;
        }
    }

}
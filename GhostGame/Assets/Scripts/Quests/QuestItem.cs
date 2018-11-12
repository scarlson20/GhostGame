using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{

    public int questNumber;

    private QuestManager theQM;

    public string itemName;

    private SFXManager sfxMan;

    // Use this for initialization
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
        sfxMan = FindObjectOfType<SFXManager>();
        theQM.quests[questNumber].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Keeps track of when quest object is collected
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ghost")
        {
            if (!theQM.questCompleted[questNumber] && theQM.quests[questNumber].gameObject.activeSelf)
            {
                theQM.itemCollected = itemName;
                gameObject.SetActive(false);
                sfxMan.itemPickedUp.Play();
            }
        }
    }
}

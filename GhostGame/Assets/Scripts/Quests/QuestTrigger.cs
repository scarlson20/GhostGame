﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{

    private QuestManager theQM;

    public int questNumber;

    public bool startQuest;
    public bool endQuest;

    // Use this for initialization
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Allows completion of quest
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ghost")
        {
            if(!theQM.questCompleted[questNumber] && (startQuest == true))
            {
                theQM.quests[questNumber].gameObject.SetActive(true);
            }
        }
    }
}

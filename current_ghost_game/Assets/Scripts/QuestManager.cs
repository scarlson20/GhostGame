﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    public QuestObject[] quests;
    public bool[] questCompleted;

    public string itemCollected;

    void Start()
    {
        questCompleted = new bool[quests.Length];

    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{

    public int questNumber;

    public bool isItemQuest;
    public string targetItem;

    public QuestManager theQM;

    void Start()
    {

    }

    void Update()
    {
        if(isItemQuest)
        {
            if(theQM.itemCollected == targetItem)
            {
                theQM.itemCollected = null;
                EndQuest();
            }
        }
    }

    public void StartQuest()
    {

    }

    public void EndQuest()
    {
        theQM.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}

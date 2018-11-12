using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIBandCollection : MonoBehaviour
{

    [SerializeField] Image[] bandMembers;
    public int counter;  // tracks total number of members in band
    public string newGameScene;
    private SFXManager sfxMan;
    private bool panelExists;


    //called to add members to band panel
    public void SetPanel(string instrument)
    {
        UpdateBand(instrument);
    }

    //sets the UI panel to contain no band member images
    public void SetPanelStart()
    {
        sfxMan = FindObjectOfType<SFXManager>();

        if(!panelExists)
        {
            panelExists = true;
            for (int i = 0; i < bandMembers.Length; i++)
            {
                bandMembers[i].enabled = false;
            }
            counter = 0;
        }
    }

    private void Update()
    {
        if (counter >= 4)
        {
            SceneManager.LoadScene(newGameScene);
        }
    }

    /// Updates the number of members currently in your band 
    /// after collecting their instrument
    void UpdateBand(string instrument)
    {
        if (instrument == "Piano" && (bandMembers[0].enabled == false))
        {
            bandMembers[0].enabled = true;
            counter++;
        }
        if (instrument == "Drums" && (bandMembers[1].enabled == false))
        {
            bandMembers[1].enabled = true;
            counter++;
        }
        if (instrument == "Guitar" && (bandMembers[2].enabled == false))
        {
            bandMembers[2].enabled = true;
            counter++;
        }
        if (instrument == "Bass" && (bandMembers[3].enabled == false))
        {
            bandMembers[3].enabled = true;
            counter++;
        }
        sfxMan.questComplete.Play();
    }
}
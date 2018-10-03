using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBandCollection : MonoBehaviour {

    [SerializeField] Image[] bandMembers;


    //called to update band panel
    public void SetPanel(string instrument)
    {
        UpdateBand(instrument);
    }

    //sets the panel to no images
    public void SetPanelStart() {
        for (int i = 0; i < bandMembers.Length; i++)
        {
            bandMembers[i].enabled = false;
        }
    }


    /// Shows the number of members you have in your band
    void UpdateBand(string instrument)
    {
        if (instrument == "Piano") {
            bandMembers[0].enabled = true;
        }
        if (instrument == "Drums")
        {
            bandMembers[1].enabled = true;
        }
        if (instrument == "Guitar")
        {
            bandMembers[2].enabled = true;
        }
        if (instrument == "Bass")
        {
            bandMembers[3].enabled = true;
        }

    }
}

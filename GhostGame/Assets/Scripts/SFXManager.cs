using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    // sound variable that plays when an item is picked up
    public AudioSource itemPickedUp;
    // sound variable that plays when a quest is completed
    public AudioSource questComplete;
    // sound variable that plays when the character enters a new scene
    public AudioSource changeScene;

    // true if a sound effects manager exists
    private static bool sfxmanExists;

    // ensures the sound effects manager remains alive for every scene
    void Start()
    {
        if (!sfxmanExists)
        {
            sfxmanExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

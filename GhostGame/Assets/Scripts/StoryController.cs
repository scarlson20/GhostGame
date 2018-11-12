using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryController : MonoBehaviour {

    public Image[] images;
    public string newGameScene;

    // Use this for initialization
    void Start () {
        StartCoroutine(StoryTeller());
    }

    // Create beginning cutscene
    IEnumerator StoryTeller()
    {
        yield return new WaitForSeconds(5);
        for (int i = 0; i < images.Length; i++)
        {
            images[i].enabled = false;
            yield return new WaitForSeconds(5);

        }
        SceneManager.LoadScene(newGameScene);
    }


}

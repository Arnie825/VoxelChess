using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScreenButton : MonoBehaviour
{
    // script to move onto the next sence when the button is pressed
    public void ButtonClick()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void ButtonClickQuit()
    {
        Application.Quit();
    }
}


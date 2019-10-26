using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

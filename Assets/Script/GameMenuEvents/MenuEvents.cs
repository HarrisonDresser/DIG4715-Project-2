using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuButton : MonoBehaviour
{
     public void ReplayGame()
    {
        SceneManager.LoadScene("Lab1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
   
}

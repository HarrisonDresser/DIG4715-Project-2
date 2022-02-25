using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu_script : MonoBehaviour
{
    public bool gamePause = false;
    public GameObject MenuUI;
    public Image pauseMenuIMG;
    public bool ImgOn;
    public GameObject creditsBox;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (gamePause)
            {
                Resume();
            }
            else 
            {
                Pause();
            }

        }

    }
    public void Pause ()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0;
        gamePause = true;
        Debug.Log("pause Game..");

    }
    public void Resume()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1;
        gamePause = false;
        Debug.Log("Resume Game..");
    }

    public void Credits()
    {
        pauseMenuIMG.enabled = true;
        ImgOn = true;
        Debug.Log("Credits Display..");
    }


    public void Quit()
    {
        
        SceneManager.LoadScene("MainScene");
        Debug.Log("Quiting Game..");
    }


}

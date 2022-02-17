using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu_script : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public Sprite newSprite;
    public GameObject creditsBox;
    public Image img;
    public bool isImgOn;
    // Start is called before the first frame update
    void Start()
    {
        //img.enabled = false;
        //isImgOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            {
                Application.Quit();
            }

    }

    //START BUTTON FUNCTIONS
    public void StartGame()
    {
        SceneManager.LoadScene("Lab1");
        Time.timeScale = 1;
    }

    //CREDIT BUTTON FUNCTIONS
    public void Credits()
    {
        img.enabled = true;
        isImgOn = true;
        /*
        if (isImgOn == false)
        {
            img.enabled = true;
            isImgOn = true;
        }
        else if (isImgOn == true)
        {
            img.enabled = false;
            isImgOn = false;
        }
        */
        Debug.Log("Credits is triggering");
    }


    //QUIT BUTTON FUNCTIONS
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit is triggering");
    }

}

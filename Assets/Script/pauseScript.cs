using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseScript : MonoBehaviour
{
    public Image pause;
    public bool isImgOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      if (Input.GetKeyDown("p"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
               // pause.enabled = true;
                //isImgOn = true;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

    }
}

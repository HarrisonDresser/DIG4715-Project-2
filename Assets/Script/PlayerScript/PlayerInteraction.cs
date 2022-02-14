using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool isSwitch1Range;
    public bool isSwitch2Range;

    public GameObject movingDoor1;
    public GameObject movingDoor2;
    public GameObject movingDoor3;


    void Start()
    {

    }

    void Update()
    {
        MovingDoor();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "switch1")
            isSwitch1Range = true;

        if (other.gameObject.tag == "switch2")
            isSwitch2Range = true;

    }

    void OnTriggerExit(Collider other)
    {
        isSwitch1Range = false;
        isSwitch2Range = false;
    }

    void MovingDoor()
    {
        if (isSwitch1Range)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor1.SetActive(true);
                movingDoor2.SetActive(false);
                isSwitch1Range = false;
            }
        }


         if (isSwitch2Range)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor1.SetActive(true);
                movingDoor3.SetActive(false);
                movingDoor2.SetActive(true);
            }
        }
    }
}

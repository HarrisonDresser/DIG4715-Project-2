using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool isSwitch1InRange;
    public bool isSwitch2InRange;
    public bool isKeyInRange;
    public bool isCageInRange;

    public bool hasKey;
    public bool aiFollowPlayer;


    public GameObject movingDoor1;
    public GameObject movingDoor2;
    public GameObject cageDoor;
    public GameObject key;

    void Update()
    {
        DoorInteraction();
        KeyInteraction(key);
        PrisonDoorInteraction(cageDoor);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "switch1")
            isSwitch1InRange = true;

        if (other.gameObject.tag == "switch2")
        {
            isSwitch2InRange = true;

        }

        if (other.gameObject.tag == "key")
        {
            isKeyInRange = true;
            Debug.Log("Key is in range");
        }

        if (other.gameObject.tag == "cageDoor")
            isCageInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        isSwitch1InRange = false;
        isSwitch2InRange = false;
        isKeyInRange = false;
        isCageInRange = false;
    }

    void DoorInteraction()
    {
        if (isSwitch1InRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor1.SetActive(false);
            }
        }


        if (isSwitch2InRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor2.SetActive(false);
            }
        }
    }

    void KeyInteraction(GameObject key)
    {
        if (isKeyInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(key);
                hasKey = true;
                Debug.Log("Key destroyed");
            }
        }
    }

    public void PrisonDoorInteraction(GameObject cageDoor)
    {
        if (isCageInRange && hasKey)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                cageDoor.transform.Translate(0, -20f, 0f);
                aiFollowPlayer = true;
            }
        }
    }
}

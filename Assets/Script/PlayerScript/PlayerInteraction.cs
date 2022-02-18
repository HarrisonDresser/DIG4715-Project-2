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
    public GameObject movingDoor3;
    public GameObject prisionDoor;
    public GameObject key;

    void Update()
    {
        DoorInteraction();
        KeyInteraction(key);
        PrisonDoorInteraction(prisionDoor);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "switch1")
            isSwitch1InRange = true;

        if (other.gameObject.tag == "switch2")
            isSwitch1InRange = true;

        if (other.gameObject.tag == "key")
            isKeyInRange = true;

        if (other.gameObject.tag == "cageDoor")
            isCageInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        isSwitch2InRange = false;
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
                movingDoor1.SetActive(true);
                movingDoor2.SetActive(false);
                isSwitch1InRange = false;
            }
        }


        if (isSwitch2InRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor1.SetActive(true);
                movingDoor3.SetActive(false);
                movingDoor2.SetActive(true);
            }
        }
    }

    void KeyInteraction(GameObject key)
    {
        if (isKeyInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                movingDoor1.SetActive(false);
                movingDoor3.SetActive(false);
                movingDoor2.SetActive(false);
                Destroy(key);
                hasKey = true;
            }
        }
    }

    void PrisonDoorInteraction(GameObject prisionDoor)
    {
        if (isCageInRange && hasKey)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                prisionDoor.transform.Translate(0, 20f, 0f);
                aiFollowPlayer = true;
            }
        }
    }
}

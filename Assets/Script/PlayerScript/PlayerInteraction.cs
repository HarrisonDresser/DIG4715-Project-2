using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool isSwitch1InRange;
    public bool isSwitch2InRange;
    public bool isKeyInRange;
    public bool isCageInRange;

    //DelayTime
    public float gateSceneWaitTime;

    public bool hasKey;
    public bool aiFollowPlayer;


    //Interactable objects
    public GameObject movingDoor1;
    public GameObject movingDoor2;
    public GameObject cageDoor;
    public GameObject key;
    public GameObject DialogueCollider;

    //CAMERA FUNCTIONS 
    public Camera MainCamera;
    public Camera NpcCamera;
    public Camera Door1Camera;
    public Camera Door2Camera;

    //Animator Variables

    public GateScript gateScript;
    public GateScript gateScript2;
    public GateScript gateScript3;
    public GateScript gateScript4;

    public DialogueTrigger dialogueTrigger;
    public SwitchScript switchScript;
    public SwitchScript switchScript2;
    PlayerMovement playerMovement;

    Rigidbody m_Rigidbody;

    void Awake()
    {
        playerMovement=GetComponent<PlayerMovement>();
    }

    void Start()
    {
        MainCamera.enabled = true;
        NpcCamera.enabled = false;
        Door1Camera.enabled = false;
        Door2Camera.enabled = false;


    }

    void Update()
    {
        DoorInteraction();
        KeyInteraction(key);
        PrisonDoorInteraction(cageDoor);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "switch1")
        {
            isSwitch1InRange = true;
        }


        if (other.gameObject.tag == "switch2")
        {
            isSwitch2InRange = true;
        }


        if (other.gameObject.tag == "Dialogue1")
        {
            MainCamera.enabled = false;
            NpcCamera.enabled = true;
            dialogueTrigger.TriggerDialogue();
            StartCoroutine(CameraWait());
            Destroy(DialogueCollider, 5);
            Debug.Log("trigger entered");

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
                //movingDoor1.SetActive(false);
                switchScript.switch1Triggered();
                MainCamera.enabled = false;
                Door1Camera.enabled = true;
                playerMovement.enabled=false;
                gateScript.GateMovement();
                StartCoroutine(CameraWait());

            }
        }


        if (isSwitch2InRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //movingDoor2.SetActive(false);
                switchScript2.switch2Triggered();
                MainCamera.enabled = false;
                Door2Camera.enabled = true;
                playerMovement.enabled=false;
                gateScript2.GateMovement2();
                StartCoroutine(CameraWait());
                

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
                //cageDoor.transform.Translate(0, -20f, 0f);
                gateScript3.CellDoor();
                gateScript4.CellDoor();
                aiFollowPlayer = true;
            }
        }
    }

    IEnumerator CameraWait()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(gateSceneWaitTime);
        NpcCamera.enabled = false;
        Door1Camera.enabled = false;
        Door2Camera.enabled = false;
        MainCamera.enabled = true;
        playerMovement.enabled=true;
        



        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }


}

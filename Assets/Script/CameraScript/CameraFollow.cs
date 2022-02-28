using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera MainCamera;
    public Camera NpcCamera;
    public Camera Door1Camera;
    public Camera Door2Camera;



    public GameObject player;
    private Vector3 cameraPosition = new Vector3(3, 10, 0);
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        NpcCamera.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraPosition;

     

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dialogue1")
        {
            MainCamera.enabled = false;
            NpcCamera.enabled = true;
            Debug.Log("trigger entered");
        }
    }

}

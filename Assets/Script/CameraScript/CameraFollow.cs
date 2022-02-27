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

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraPosition;

     

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Dialogue1"))
        {

        }
    }

}

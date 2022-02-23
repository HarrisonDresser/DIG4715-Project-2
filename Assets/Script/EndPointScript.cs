using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointScript : MonoBehaviour
{
    public GameObject victoryPannel;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("Two Characters are detected");
            victoryPannel.SetActive(true);
        }

    }
}

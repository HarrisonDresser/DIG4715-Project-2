using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnCollision : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "swingingAxe")
        {
            Debug.Log("Collided");
            rb.constraints= RigidbodyConstraints.None;

        }

    }

}

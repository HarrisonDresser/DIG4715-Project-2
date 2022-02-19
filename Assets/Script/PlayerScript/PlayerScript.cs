using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;

    private float horizontalMove;
    private float verticalMove;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove).normalized;
        transform.Translate(moveDirection * speed * Time.deltaTime);

        //Needto research about character rotation
        // Quaternion rotation = Quaternion.LookRotation(moveDirection);
        //rb.MoveRotation(rotation);
    }
}



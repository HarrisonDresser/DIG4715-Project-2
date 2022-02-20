using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private float horizontalMove;
    private float verticalMove;
    private Rigidbody rb;
    public float rotationSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(-verticalMove, 0, horizontalMove);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

        if(moveDirection!=Vector3.zero)
        {
            transform.forward=moveDirection;

        }

    }
}



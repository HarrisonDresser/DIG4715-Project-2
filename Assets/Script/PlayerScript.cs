using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed=5f;

    private float horizontalMove;
    private float verticalMove;
    private Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove=Input.GetAxis("Horizontal");
        verticalMove=Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalMove);
        transform.Translate(Vector3.right*  Time.deltaTime * speed * horizontalMove);
    }
}

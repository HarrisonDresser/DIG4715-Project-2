using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public PlayerInteraction player;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.SetBool("IsOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void GateMovement()
    {
        Debug.Log("called");
        //animator.SetBool("IsOpen", true);
        animator.Play("gateOpen");
    }

    public void GateMovement2()
    {
        animator.Play("gateOpen2");
    }

    public void CellDoor()
    {
        animator.Play("CellDoor-Open");
    }
    

}

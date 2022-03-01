using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    Animator animator;
    public PlayerInteraction player;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        //animator.SetBool("isActivated",false);
        
    }

    public void switch1Triggered ()
    {
        animator.Play("Triggering");
        animator.SetBool("isActivated",true);
    }

     public void switch2Triggered ()
    {
        animator.Play("Switch2_Activated");
        //animator.SetBool("isActivated",true);
        //animator.SetBool("SwitchOn",true);
        Debug.Log("I'm here");
    }
}

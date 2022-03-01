using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    public void switch1Triggered ()
    {
        animator.Play("Triggering");
        animator.SetBool("isActivated",true);
    }

     public void switch2Triggered ()
    {
        
        animator.SetBool("Activated",true);
        Debug.Log("I'm here");
    }
}

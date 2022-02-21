using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject player;
    PlayerInteraction playerInteraction;
    public Transform target;

    NavMeshAgent nav;
    // Start is called before the first frame update
    void Awake()
    {
        playerInteraction = player.GetComponent<PlayerInteraction>();
        Debug.Log("PlayerInteraction scripts is successfully called");
    }

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        AIFollowCondtion();
    }

    void AIFollowCondtion()
    {
        if (playerInteraction.aiFollowPlayer)
        {
            nav.SetDestination(target.position);
        }
    }
}

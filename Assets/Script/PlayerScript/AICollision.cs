using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class AICollision : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    NavMeshAgent ai;

    PlayerMovement playerMovement; //access to playerMovement Script


    public GameObject gameOverPanel;
    public bool isGameOver = false;
    public bool isNPCkilled=false;
    public GameObject NPCKilledImage;

    // Start is called before the first frame update
    void Awake()
    {
        playerMovement=GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ai = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("lab1");
        }
    }

    void OnCollisionEnter(Collision other) //DetectCollision of the objects by searching for tags
    {
        if (other.collider.tag == "swingingAxe" || other.collider.tag == "cannon")
            isGameOver = true;
            isNPCkilled= true;
        GameOverSystem();
    }

    void GameOverSystem() //Axe Interaction
    {
        if (isGameOver && isNPCkilled)
        {
            ai.isStopped = true;
            rb.constraints = RigidbodyConstraints.None;
            gameOverPanel.SetActive(true);
            NPCKilledImage.SetActive(true);
            playerMovement.enabled=false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnCollision : MonoBehaviour
{
    private Rigidbody rb;

    PlayerMovement playerMovement;


    public GameObject playerKilledPannel;
    public GameObject gameOverPanel;
    public bool isGameOver = false;
    public bool isPlayerKilled= false;

    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

     void OnCollisionEnter(Collision other) //DetectCollision of the objects by searching for tags
    {
        if (other.collider.tag == "swingingAxe" || other.collider.tag == "cannon")
        {
            isGameOver=true;
            isPlayerKilled=true;
            GameOverSystem();
        }
    }

    public void GameOverSystem() //Axe Interaction
    {
        if (isGameOver&& isPlayerKilled)
        {
            playerMovement.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
            gameOverPanel.SetActive(true);
            playerKilledPannel.SetActive(true);
        }
    }
}

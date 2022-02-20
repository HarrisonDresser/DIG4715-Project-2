using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnCollision : MonoBehaviour
{
    private Rigidbody rb;

    PlayerMovement playerMovement;

    public GameObject gameOverPanel;
    public bool isGameOver = false;

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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("lab1");
        }
    }

    void OnCollisionEnter(Collision other) //DetectCollision of the objects by searching for tags
    {
        if (other.collider.tag == "swingingAxe" || other.collider.tag == "cannon")
            isGameOver=true;
            GameOverSystem();
    }

    void GameOverSystem() //Axe Interaction
    {
        if (isGameOver)
        {
            playerMovement.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
            gameOverPanel.SetActive(true);
        }
    }
}

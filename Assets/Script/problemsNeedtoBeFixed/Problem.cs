using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PROBLEM
        //Ground boxcollider height difference issue >> maybe adding a capsule collider at the bottom of the character might solve
        //Piviot point of the main character and AI needs to be centered
        //AI path is not properly read for the AI movement path >> Not sure yet how we can solve this problem
        //Some Box colliders that are attached to the walls need to be adjusted (some walls allow player to go through the wall)


        
        //TO DO
        //MAKE Win condition for the game
        //Door animation
        //Maybe we should make delay(about 2 seconds?) after player has hit by an obstacle
        //Sound effect
        //If possible find best camera angle for the game ( may be camera angle changes depending on the direction the player is moving)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

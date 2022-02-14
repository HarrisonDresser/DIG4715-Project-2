using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingAxe : MonoBehaviour
{
    public float speed;
    private int phase = 0;
    private float timer = 0f;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {

        timer += Time.fixedDeltaTime;
        if (timer > 1)
        {
            phase++;
            phase %= 4;
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(speed * (1 - timer), 0, 0);
                break;

            case 1:
                transform.Rotate(-speed * timer, 0, 0);
                break;

            case 2:
                transform.Rotate(-speed * (1 - timer), 0, 0);
                break;

            case 3:
                transform.Rotate(speed * timer, 0, 0);
                break;
        }
        /*
            transform.Rotate(Vector3.right * speed, 0, 0);

            if (transform.rotation.x > maxAngle)
                speed *= -1;
                Debug.Log("tic");


            if (transform.rotation.x > -maxAngle)
                speed *= 1;
                 Debug.Log("tok");
                 */
    }
}

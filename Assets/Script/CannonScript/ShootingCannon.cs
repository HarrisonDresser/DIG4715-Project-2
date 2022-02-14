using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCannon : MonoBehaviour
{
    public Transform firePosition;
    public GameObject bullet;
    public float delayTime;
    public float intervalTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AutoShooting", delayTime , intervalTime);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AutoShooting()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }
}

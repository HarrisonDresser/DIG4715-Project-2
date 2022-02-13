using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Measurer : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Size;
    //public Render render;


    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Size = m_Collider.bounds.size;
        Debug.Log("Collider Size : " + m_Size);
        //GetComponent<Collider>().bounds.size;
        //GetComponent<Collider>().bounds.size;
        //GetComponent<Renderer>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

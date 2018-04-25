using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 m_Velocity;
    public bool m_WorldSpace = false;
    
    void Start()
    {

    }
    
    void Update()
    {
        transform.Rotate(m_Velocity * Time.deltaTime,
            m_WorldSpace ? Space.World : Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 効果線Controller : MonoBehaviour
{
    public float m_Intensity = 1f;

    ParticleSystem m_Particle;
    float m_BaseRate;

    void Start()
    {
        m_Particle = GetComponentInChildren<ParticleSystem>();
        m_BaseRate = m_Particle.emission.rateOverTime.constant;
    }
    
    void Update()
    {
        
        var emission = m_Particle.emission;
        emission.rateOverTime = m_Intensity * m_BaseRate;
    }
}

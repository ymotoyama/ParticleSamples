using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityController : MonoBehaviour
{
    public float m_Duration = 1f;
    public AnimationCurve m_Curve;

    Light m_Light;
    float m_BaseIntensy;
    float m_StartTime;

    void Reset()
    {
        m_Curve = new AnimationCurve();
        m_Curve.AddKey(0f, 1f);
        m_Curve.AddKey(0.1f, 0.99f);
        m_Curve.AddKey(1f, 0f);
    }

    void Start()
    {
        m_Light = GetComponentInChildren<Light>();
        m_BaseIntensy = m_Light.intensity;
        m_StartTime = Time.time;        
    }
    
    void Update()
    {
        float elapsed = Time.time - m_StartTime;
        float progressRate = elapsed / m_Duration;
        progressRate = Mathf.Clamp01(progressRate);

        m_Light.intensity = m_Curve.Evaluate(progressRate) * m_BaseIntensy;
    }
}

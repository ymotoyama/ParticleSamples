using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public float m_Rate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var emission = GetComponent<ParticleSystem>().emission;
        emission.rateOverTime = m_Rate;
	}
}

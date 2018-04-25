using UnityEngine;
using System.Collections;

public class LifeTime : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}

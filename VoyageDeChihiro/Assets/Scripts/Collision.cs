using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void Start()
    {
        
    }

    public float groundHeight = -0.1f;

    void Update()
    {
        if (transform.position.y < groundHeight)
        {
            Vector3 newPosition = new Vector3(transform.position.x, groundHeight, transform.position.z);
            transform.position = newPosition;
        }
    }
}
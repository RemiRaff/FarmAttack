using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35.0f;
    private float lowerBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (topBound < transform.position.z)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
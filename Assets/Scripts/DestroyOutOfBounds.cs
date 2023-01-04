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
        // if an object goes past the player view, destroy it (memory cleanup)
        if (topBound < transform.position.z)
        {
            // destroy food
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            // destroy animal
            Destroy(gameObject);
            Debug.Log("An animal wins...");
        }
    }
}

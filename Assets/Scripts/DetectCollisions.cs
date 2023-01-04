using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO OnCollisionEnter ne fonctionne pas, pourquoi?
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Collision detected...");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // speed of farmer
    public float speed = 2000.0f;

    private Rigidbody _rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Debug.Log("Move");
        _rb.velocity = new Vector2(movementValue.Get<Vector2>().x, 0) * speed * Time.deltaTime;
    }

    void OnFire()
    {
        Debug.Log("Fire");
    }
}

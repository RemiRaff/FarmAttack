using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // speed of farmer
    public float speed = 2000.0f;
    public float bound = 15.0f; // right and left boundary pour un champ non sym�trique
    public GameObject projectilePrefab; // pizza � lancer
    public Vector3 projectilePrefabPosition;

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in the field (with bound value)
        // mieux dans Update que dans le OnMove
        if (_rb.position.x <= -bound) // velocity et add force autre fa�on de g�n�rer du mouvement avec rigidbody
        {
            _rb.position = new Vector3(-bound, _rb.position.y, _rb.position.z);
        } else if (bound <= _rb.position.x)
        {
            _rb.position = new Vector3(bound, _rb.position.y, _rb.position.z);
        }
    }

    // Pour cr�er des blocs #region <region name> ... #endregion
    public void OnMove(InputAction.CallbackContext ctx)
    {
        // peut �tre fait avec un Axis(float) plutot qu'un Vector2 dans le PlayerAction
        _rb.velocity = new Vector2(ctx.ReadValue<Vector2>().x, 0) * speed * Time.deltaTime;
    }

    public void OnFire(InputAction.CallbackContext ctx)
    {
        // Debug.Log("Fire");
        if (ctx.started) // performed, canceled
        {
            Instantiate(projectilePrefab, new Vector3(_rb.position.x, _rb.position.y + 0.25f, _rb.position.z + 1), projectilePrefab.transform.rotation);
        }
    }
}

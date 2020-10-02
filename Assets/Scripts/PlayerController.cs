using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = movementSpeed * new Vector3(verticalMovement, 0, horizontalMovement).normalized;

        transform.Translate(movement, Space.Self);
    }
}

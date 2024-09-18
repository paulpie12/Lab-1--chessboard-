using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movementInput;

    private float speed = 6f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = movementInput * speed;
    }

    private void OnMove(InputValue inputValue)
    {
       movementInput = inputValue.Get<Vector2>(); 
    }
}

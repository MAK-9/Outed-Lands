using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager input;
    private Rigidbody rb;

    [SerializeField] private float movementSpeed=5f;
    [SerializeField] private float jumpForce=3f;

    private void Awake()
    {
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moveVector = new Vector3(0f, 0f, 0f)
        {
            x = movementSpeed * input.GetHorizontalAxis(), z = movementSpeed * input.GetVerticalAxis()
        };


        rb.AddForce(moveVector);
    }

    void Jump()
    {
        if (IsGrounded() && input.Jump())
        {
            rb.AddForce(new Vector3(0, jumpForce, 0),ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        //TODO implement this
        return true;
    }
}

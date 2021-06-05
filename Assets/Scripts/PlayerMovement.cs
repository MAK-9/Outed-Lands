using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GravityBody gravityBody;
    
    private InputManager input;
    private Rigidbody rb;

    [SerializeField] private float movementSpeed=5f;
    [SerializeField] private float jumpForce=0.5f;
    [SerializeField] private float playerSpeed = 1f;

    private bool isGrounded = false;

    private void Awake()
    {
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
        gravityBody = GetComponent<GravityBody>();
    }

    private void Update()
    {
        Move();
        Jump();
        Look();
        Fall();
    }

    void Move()
    {
        Vector3 moveVector = new Vector3();
        moveVector = transform.forward * input.GetVerticalAxis() + transform.right * input.GetHorizontalAxis();
        moveVector *= Time.deltaTime * playerSpeed;


        rb.AddForce(moveVector);
    }

    void Fall()
    {
        if (!isGrounded)
        {
            rb.AddForce(gravityBody.GetAttractVector());
        }
    }

    void Look()
    {
        float mouseDeltaX = input.GetMouseDelta().x;
        transform.Rotate(new Vector3(0f,mouseDeltaX,0f));
    }

    void Jump()
    {
        if (isGrounded && input.Jump())
        {
            rb.AddForce(new Vector3(0, jumpForce, 0),ForceMode.Impulse);
            Debug.Log("JUMP");
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

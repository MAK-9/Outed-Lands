using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GravityBody gravityBody;
    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;
    
    private InputManager input;
    private Rigidbody rb;
    public GameObject inventoryPanel;

    [SerializeField] private float movementSpeed=5f;
    [SerializeField] private float jumpForce=0.5f;
    [SerializeField] private float playerSpeed = 1f;

    private bool isGrounded = false;

    private void Awake()
    {
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
        gravityBody = GetComponent<GravityBody>();
        
        //initialize inventory
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        //ItemWorld.SpawnItemWorld(transform.position, new Item {itemType = Item.ItemType.Wood, amount = 1});
        
    }

    private void Update()
    {
        Move();
        Jump();
        Look();
        Fall();
        ToggleInventory();
    }

    private void LateUpdate()
    {
        AdjustAngleToGravity();
        
        //debug
        //Debug.DrawRay(transform.position, gravityBody.CalculateGravityDirectionVector(), Color.magenta);
        //Debug.Log("Angle "+gravityBody.CalculateAngleToPlanetSurface());
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
            //Debug.Log("Falling due to "+gravityBody.GetAttractVector()+" of force!");
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
            
            rb.AddForce(gravityBody.CalculateGravityDirectionVector() * (jumpForce * -1),ForceMode.Impulse);
        }
    }

    void AdjustAngleToGravity()
    {
      Quaternion targetRotation = Quaternion.FromToRotation(transform.up, -1 * gravityBody.CalculateGravityDirectionVector())
            * transform.rotation;
      transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 50);
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

    void ToggleInventory()
    {
        if (input.ToggleInventory())
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}

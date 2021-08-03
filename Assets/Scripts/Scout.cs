using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : MonoBehaviour
{
    private Transform cameraTransform;
    private Transform playerTransform;
    private Rigidbody rb;
    private float launchForce = 30f;
    private GravityBody gravityBody;
    private Scout instance;
    public event Action landedEvent;

    private void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        gravityBody = transform.GetComponent<GravityBody>();
    }

    private void Start()
    {
        AdjustRotationToPlayer();
    }

    private void Update()
    {
        Fall();
    }
    
    
    void Fall()
    {
        rb.AddForce(gravityBody.GetAttractVector());
    }

    void AdjustRotationToPlayer()
    {
        transform.rotation = playerTransform.rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            if (collision.contacts[0].thisCollider.transform == transform)
            {
                LandOnSurface(collision);
                landedEvent();
            } 
        }
    }

    void LandOnSurface(Collision collision)
    {
        transform.up = collision.contacts[0].normal;
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}

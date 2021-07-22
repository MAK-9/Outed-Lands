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
        //ApplyLaunchForce();
    }

    private void Update()
    {
        Fall();
    }

    private void ApplyLaunchForce()
    {
        //TODO fix this vvv
        rb.AddForce(cameraTransform.forward * launchForce,ForceMode.Impulse);
    }
    
    void Fall()
    {
        rb.AddForce(gravityBody.GetAttractVector());
    }

    void AdjustRotationToPlayer()
    {
        transform.rotation = playerTransform.rotation;
    }
    
}

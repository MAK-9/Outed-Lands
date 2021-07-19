using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : MonoBehaviour
{
    private Transform cameraTransform;
    private Rigidbody rb;
    private float launchForce = 15f;
    private GravityBody gravityBody;
    private Scout instance;

    private void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        gravityBody = transform.GetComponent<GravityBody>();
    }

    private void Start()
    {
        ApplyLaunchForce();
    }

    private void Update()
    {
        Fall();
    }

    private void ApplyLaunchForce()
    {
        //TODO fix this vvv
        rb.AddForce(cameraTransform.position + cameraTransform.forward * launchForce,ForceMode.Impulse);
    }
    
    void Fall()
    {
        rb.AddForce(gravityBody.GetAttractVector());
    }
    
}

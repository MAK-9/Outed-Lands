using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Wood : MonoBehaviour
{
    private Rigidbody rb;
    private BoxCollider collider;
    private Vector3 launchVector = new Vector3(0f, 5f, 0f);
    private Vector3 awakeRotation = new Vector3(0f, 0f, -90f);

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
        transform.rotation = Quaternion.Euler(awakeRotation);
    }

    private void Start()
    {
        Launch();
    }

    void Launch()
    {
        rb.velocity = launchVector;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Axe"))
        {
            if (collision.contacts[0].thisCollider.transform == transform)
            {
                LandOnSurface(collision);
            } 
        }
    }

    void LandOnSurface(Collision collision)
    {
        transform.up = collision.contacts[0].normal;
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    private Vector3 gravityVectorNormalized;
    public GravitySource[] attractors;

    private void Awake()
    {
        
    }

    // attract body to gravity vector
    void Attract(Rigidbody rb)
    {
        rb.AddForce(gravityVectorNormalized);
    }

    Vector3 CalculateGravityVector()
    {
        Vector3 gravityDirection = transform.position - attractors[0].transform.position;
        return gravityDirection;
    }
}

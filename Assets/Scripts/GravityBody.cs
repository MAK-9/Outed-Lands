using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    private Vector3 gravityVectorNormalized;
    private GravitySource[] attractors;

    private void Awake()
    {
        
    }

    // attract body to gravity vector
    void Attract(Rigidbody rb)
    {
        rb.AddForce(gravityVectorNormalized * gravityStrength);
    }
}

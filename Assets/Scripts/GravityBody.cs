using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public GravitySource[] attractors;
    
    // attract body to gravity vector
    public Vector3 GetAttractVector()
    {
        return CalculateGravityDirectionVector() * attractors[0].strength;
    }

    public Vector3 CalculateGravityDirectionVector()
    {
        Vector3 gravityDirection = transform.position - attractors[0].transform.position;
        gravityDirection.Normalize();
        return gravityDirection * -1;
    }
}

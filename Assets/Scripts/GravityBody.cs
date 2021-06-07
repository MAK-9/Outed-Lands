using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public GravitySource[] attractors;

    private Vector3 gravityDirection;
    
    // attract body to gravity vector
    public Vector3 GetAttractVector()
    {
        return CalculateGravityDirectionVector() * attractors[0].strength;
    }

    public Vector3 CalculateGravityDirectionVector()
    {
        gravityDirection = attractors[0].transform.position - transform.position;
        gravityDirection.Normalize();

        return gravityDirection;
    }

    public float CalculateAngleToPlanetSurface()
    {
        float angle = Mathf.Atan2(gravityDirection.y, gravityDirection.x) * Mathf.Rad2Deg + 90f;
        return angle;
    }
}

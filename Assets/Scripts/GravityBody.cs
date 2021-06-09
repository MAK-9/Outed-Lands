using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public GravitySource[] attractors;

    private Vector3 gravityDirection;

    [SerializeField] private float mass = 50f;
    [SerializeField] float g = 10f; // gravitational constant

    // attract body to gravity vector
    public Vector3 GetAttractVector()
    {
        // Fg = G * (Mm/r^2)
        float r = GravitationalDistance();
        float gravityForce = (g * mass * attractors[0].mass) / (r*r);
        return CalculateGravityDirectionVector() * gravityForce;
    }

    private float GravitationalDistance()
    {
        float distance = Vector3.Distance(transform.position, attractors[0].transform.position);
        Debug.Log("Distance from the planet = "+distance);
        return distance;
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

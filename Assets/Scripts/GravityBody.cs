using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    private GameObject[] attractors = new GameObject[3];

    private Vector3 gravityDirection;

    [SerializeField] private float mass = 50f;
    [SerializeField] private float g = 10f; // gravitational constant
    [SerializeField] private float gravityRadius = 1000f;

    private void Start()
    {
        PopulateAttractorsArray();
    }


    // attract body to gravity vector
    public Vector3 GetAttractVector()
    {
        // Fg = G * (Mm/r^2)
        float r = GravitationalDistance();
        float gravityForce = (g * mass * attractors[FindNearestAttractor()].GetComponent<GravitySource>().mass) / (r*r);
        return CalculateGravityDirectionVector() * gravityForce;
    }

    private float GravitationalDistance()
    {
        float distance = Vector3.Distance(transform.position, attractors[FindNearestAttractor()].transform.position);
        //Debug.Log("Distance from the planet = "+distance);
        return distance;
    }
    public Vector3 CalculateGravityDirectionVector()
    {
        gravityDirection = attractors[FindNearestAttractor()].transform.position - transform.position;
        gravityDirection.Normalize();

        return gravityDirection;
    }

    public float CalculateAngleToPlanetSurface()
    {
        float angle = Mathf.Atan2(gravityDirection.y, gravityDirection.x) * Mathf.Rad2Deg + 90f;
        return angle;
    }

    int FindNearestAttractor()
    {
        float minDistance = 99999999f;
        float currentDistance;
        int attractorIndex = 0;
        for(int i = 0; i < attractors.Length; i++)
        {
            currentDistance = Vector3.Distance(transform.position, attractors[i].transform.position);
            if (minDistance > currentDistance)
            {
                minDistance = currentDistance;
                attractorIndex = i;
            }
        }

        return attractorIndex;
    }

    void PopulateAttractorsArray()
    {
        attractors[0] = GameObject.Find("Sun");
        attractors[1] = GameObject.Find("/Sun/Planet");
        attractors[2] = GameObject.Find("/Sun/Planet/Moon");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform targetTransform;
    //private Rigidbody rb;
    
    [SerializeField] private float OrbitDegrees = 1f;
    

    private void Update()
    {
        transform.position = 
            RotatePointAroundPivot(transform.position,
                transform.parent.position,
                Quaternion.Euler(0, OrbitDegrees * Time.deltaTime, 0));
    }
    
    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle) 
    {
        return angle * ( point - pivot) + pivot;
    }
}

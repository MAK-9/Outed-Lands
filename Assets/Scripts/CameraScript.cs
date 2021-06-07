using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform targetTransform;
    private InputManager input;
    private GravityBody gravityBody;

    private float currentPitch = 0f;
    [SerializeField] private float pitchSpeed = 100f;

    private void Awake()
    {
        targetTransform = GameObject.Find("Player").GetComponent<Transform>();
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        gravityBody = GameObject.Find("Player").GetComponent<GravityBody>();
    }

    private void Update()
    {
        Move();
        //RotateVertical();
    }

    private void LateUpdate()
    {
        
    }

    void Move()
    {
        float mouseY = input.GetMouseDelta().y;
        Vector3 targetRotation = targetTransform.eulerAngles;
        this.transform.position = targetTransform.position;
        //this.transform.rotation = targetTransform.rotation;

        currentPitch -= mouseY * Time.deltaTime * pitchSpeed;
        //currentPitch = Mathf.Clamp(currentPitch, gravityBody.CalculateAngleToPlanetSurface() - 90f, gravityBody.CalculateAngleToPlanetSurface()+90f);
        currentPitch = Mathf.Clamp(currentPitch, - 90f, 90f);
        Quaternion verticalRotation =  Quaternion.Euler(new Vector3(currentPitch,targetRotation.y,targetRotation.z));
        
        //adjust rotation to planet surface
        Quaternion gravitationalRotation = Quaternion.FromToRotation(transform.up, -1 * gravityBody.CalculateGravityDirectionVector())
                                           * transform.rotation;

        transform.rotation = verticalRotation * gravitationalRotation;
        //transform.rotation = Quaternion.Slerp(transform.rotation, gravitationalRotation, Time.deltaTime * 50);

    }

    void RotateVertical()
    {
        float mouseY = input.GetMouseDelta().y;
        transform.Rotate(new Vector3(mouseY,0f,0f));
    }
}

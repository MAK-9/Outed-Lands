using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform targetTransform;
    private InputManager input;

    private float currentPitch = 0f;
    [SerializeField] private float pitchSpeed = 100f;

    private void Awake()
    {
        targetTransform = GameObject.Find("Player").GetComponent<Transform>();
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
    }

    private void Update()
    {
        Move();
        //RotateVertical();
    }

    void Move()
    {
        float mouseY = input.GetMouseDelta().y;
        Vector3 targetRotation = targetTransform.eulerAngles;
        this.transform.position = targetTransform.position;
        //this.transform.rotation = targetTransform.rotation;

        currentPitch -= mouseY * Time.deltaTime * pitchSpeed;
        currentPitch = Mathf.Clamp(currentPitch, -90f, 90f);
        transform.rotation = Quaternion.Euler(new Vector3(currentPitch,targetRotation.y,targetRotation.z));
    }

    void RotateVertical()
    {
        float mouseY = input.GetMouseDelta().y;
        transform.Rotate(new Vector3(mouseY,0f,0f));
    }
}

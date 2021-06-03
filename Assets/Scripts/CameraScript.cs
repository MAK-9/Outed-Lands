using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform targetTransform;

    private void Awake()
    {
        targetTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        this.transform.position = targetTransform.position;
        this.transform.rotation = targetTransform.rotation;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutCamera : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        camera.enabled = false;
    }

    private void Update()
    {
        if (InputManager.instance.TakeShot())
        {
            TakeShot();
        }
    }

    void TakeShot()
    {
        camera.enabled = true;
        camera.Render();
        camera.enabled = false;
    }
}

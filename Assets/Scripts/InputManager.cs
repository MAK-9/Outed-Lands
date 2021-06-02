using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //TODO make this a singleton

    private InputActions input;

    private void Awake()
    {
        input = new InputActions();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    public float GetHorizontalAxis()
    {
        Vector2 vector2 = input.Jetpack.WSAD.ReadValue<Vector2>();
        return vector2.x;
    }
    public float GetVerticalAxis()
    {
        Vector2 vector2 = input.Jetpack.WSAD.ReadValue<Vector2>();
        return vector2.y;
    }

    public bool Jump()
    {
        return input.Jetpack.Jump.ReadValue<bool>();
    }

    public Vector2 GetMouseDelta()
    {
        return input.Jetpack.LookAround.ReadValue<Vector2>();
    }
}

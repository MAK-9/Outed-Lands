using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //TODO make this a singleton

    public static InputManager instance;
    private InputActions input;

    private bool didJump = false;

    private void Awake()
    {
        input = new InputActions();
        instance = this;
    }

    private void Start()
    {
        input.Jetpack.Jump.performed += _ => DidJump();
        input.Jetpack.Jump.canceled += _ => DidntJump();
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

    private void DidntJump()
    {
        didJump = false;
    }
    private void DidJump()
    {
        didJump = true;
    }

    public bool Jump()
    {
        return didJump;
    }

    public Vector2 GetMouseDelta()
    {
        return input.Jetpack.LookAround.ReadValue<Vector2>();
    }

    public bool ScoutLaunched()
    {
        return input.Jetpack.LaunchScout.triggered;
    }

    public bool TakeShot()
    {
        return input.Jetpack.TakeShot.triggered;
    }

    public bool SwingAxe()
    {
        return input.Jetpack.PrimaryAction.triggered;
    }
}

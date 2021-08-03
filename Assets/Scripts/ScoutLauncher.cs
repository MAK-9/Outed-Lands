using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ScoutLauncher : MonoBehaviour
{
    public GameObject scoutPrefab;
    private GameObject currentScout;
    public Transform cameraTransform;
    public AudioSource audioSource;

    public float launchForce = 50f;

    private void Update()
    {
        if (InputManager.instance.ScoutLaunched())
        {
            LaunchScout();
        }
    }

    private void LaunchScout()
    {
        if (currentScout != null)
        {
            Destroy(currentScout);
        }
        currentScout = Instantiate(scoutPrefab, cameraTransform.position + cameraTransform.forward * 1f, quaternion.identity);
        ApplyForceToScout();
        PlayLaunchSound();
    }

    void ApplyForceToScout()
    {
        Rigidbody scoutRb = currentScout.GetComponent<Rigidbody>();
        scoutRb.AddForce(cameraTransform.forward * launchForce);
        //scoutRb.velocity = new Vector3(cameraTransform.forward * )
    }

    void PlayLaunchSound()
    {
        audioSource.Play();
    }
}

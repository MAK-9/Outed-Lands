using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ScoutLauncher : MonoBehaviour
{
    public GameObject scoutPrefab;
    private GameObject currentScout;
    
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
        currentScout = Instantiate(scoutPrefab, transform.position, quaternion.identity);
    }
}

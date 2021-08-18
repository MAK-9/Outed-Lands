using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public InputManager input;
    public Animator animator;
    private BoxCollider collider;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        collider.enabled = false;
    }

    private void Update()
    {
        if (input.SwingAxe())
        {
            animator.SetTrigger("Swing");
        }
    }

    private void SwingComplete()
    {
        //check collisions
        collider.enabled = false;
        
    }

    void SwingStart()
    {
        collider.enabled = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        Interactable interactable = other.gameObject.GetComponent<Interactable>();
        if(interactable!=null)
            interactable.Interact(this.gameObject);
    }
}

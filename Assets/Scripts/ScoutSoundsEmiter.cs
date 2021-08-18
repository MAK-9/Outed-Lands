using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutSoundsEmiter : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    void Awake()
    {
        gameObject.GetComponentInParent<Scout>().landedEvent += PlayLandingSound;
        audioSource = GetComponent<AudioSource>();
        PlayIdleSound();
    }
    

    void PlayIdleSound()
    {
        audioSource.loop = true;
        audioSource.Play();
    }

    void PlayLandingSound()
    {
        audioSource.loop = false;
        audioSource.pitch = -3f;
        audioSource.PlayOneShot(audioClips[0]);
    }
}

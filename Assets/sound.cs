using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimatorAndSound : MonoBehaviour
{
    public Animator animator; // Assign your Animator component here
    public AudioSource audioSource; // Assign your AudioSource component here
    public AudioClip soundClip; // Assign your sound clip here

    private float delay = 2.0f; // Delay in seconds before playing the Animator and sound
    private bool hasPlayed = false;

    private void Start()
    {
        // Ensure that the Animator and AudioSource are assigned
        if (animator == null)
        {
            Debug.LogError("Animator not assigned!");
        }

        if (audioSource == null)
        {
            Debug.LogError("AudioSource not assigned!");
        }

        if (soundClip == null)
        {
            Debug.LogError("Sound clip not assigned!");
        }
    }

    private void Update()
    {
        if (!hasPlayed)
        {
            // Wait for the specified delay
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                // Play the Animator
                animator.SetTrigger("YourAnimationTrigger"); // Replace with your actual trigger parameter name

                // Play the sound
                audioSource.clip = soundClip;
                audioSource.Play();

                // Mark that the actions have been performed
                hasPlayed = true;
            }
        }
    }
}

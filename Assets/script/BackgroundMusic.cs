using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // The background music clip
    private AudioSource audioSource;

    void Start()
    {
        // Create an AudioSource component if not already attached
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background music clip
        audioSource.clip = backgroundMusic;

        // Ensure the music loops
        audioSource.loop = true;

        // Start playing the background music
        audioSource.Play();
    }
}

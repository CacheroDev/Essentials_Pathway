using UnityEngine;

public class PlayBallSFX : MonoBehaviour
{
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}

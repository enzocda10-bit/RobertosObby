using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] private AudioSource audioSource;

    public AudioClip deathSound;
    public AudioClip checkPointSound;
    public AudioClip collectItem;
    public AudioClip jumpSound;

    private void Awake()
    {
        Instance = this;
    }

    public void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotInteractableController : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false;
    }

    public void PlaySound()
    {
        _audioSource.PlayOneShot(collectSound);
    }
}

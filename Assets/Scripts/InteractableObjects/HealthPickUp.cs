using System;
using UnityEngine;

public class HealthPickUp : MonoBehaviour,IHaveAnimationEndEvent
{
    private bool _isPickedUp;
    private Animator _animator;
    private static readonly int Pickup = Animator.StringToHash("pickup");

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player && !_isPickedUp)
        {
            if(AudioManager.Instance != null)
                AudioManager.Instance.HealthPickupAudio.PlayCollectSound();
            player.PlayerHealthController.Heal();
            _animator.SetTrigger(Pickup);
            _isPickedUp = true;
        }
    }
    public void Reset()
    {
        _isPickedUp = false;
        gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        if(_isPickedUp)
            gameObject.SetActive(false);
    }

    public void OnAnimationEnd()
    {
        gameObject.SetActive(false);
    }
}

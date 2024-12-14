using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private static SoundController instance;

    public static SoundController Instance { get { return instance; } }

    [Header("---------- Audio Source ----------")]
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource sfx;

    [Header("---------- Audio Clip ----------")]
    public AudioClip background;
    public AudioClip pickUpCoin;
    public AudioClip rocket;
    public AudioClip waterFall;
    public AudioClip GroundFall;
    public AudioClip holdJump;
    public AudioClip deadSound;
    public AudioClip clickSound;
    public AudioClip gameoverSound;
    public AudioClip respawnSound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void PlayOneShot(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }

    public void Stop()
    {
        sfx.Stop();
    }
}

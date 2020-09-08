using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    void Awake() { instance = this; }

    public AudioSource audioSource;
   

   public void PlaySingle(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void Stop(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] sounds;

    private AudioSource audio_source => GetComponent<AudioSource>();

    public void PlaySound(AudioClip clip, float volume = 0.15f)
    {
        audio_source.PlayOneShot(clip, volume);
    }
}

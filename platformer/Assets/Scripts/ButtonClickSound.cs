using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{

    public AudioClip sound;

    private AudioSource audio_source => GetComponent<AudioSource>();

    public void PlaySound()
    {
        audio_source.PlayOneShot(sound);
    }
}

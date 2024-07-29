using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ESCPannelScript : MonoBehaviour
{

    public GameObject ESC_pannel;
    private Sound sound => GetComponent<Sound>();

    private bool is_esc_on = false;

    public void Awake()
    {
        ESC_pannel.SetActive(false);

    }
    public void ESC()
    {
        sound.PlaySound(sound.sounds[1]);
        is_esc_on = !is_esc_on;
        ESC_pannel.SetActive(is_esc_on);

        if (is_esc_on)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

}

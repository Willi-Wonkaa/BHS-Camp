using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class Indicators : MonoBehaviour
{
    private PlayerFullScript player_full_script;

    public Image player_hp_bar;
    public TMP_Text coins; 



    public float player_hp_amount = 1f;


    void Start()
    {
        player_full_script = GetComponent<PlayerFullScript>();
    }

    void Update()
    {
        player_hp_amount = ((float)player_full_script.hp_current / (float)player_full_script.hp_max);

        player_hp_bar.fillAmount = player_hp_amount;

        coins.text = player_full_script.coins.ToString();

    }
}

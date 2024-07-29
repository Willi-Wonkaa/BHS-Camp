using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFullScript : MonoBehaviour
{
    public StartPosition start_position;
    public ESCPannelScript ESC_pannel_script;

    public int coins;
    public int hp_max;
    public int hp_current;

    private int hp_prev;

    public float speed_scaler = 1f;

    public bool is_take_damage;

    public void Awake()
    {
        coins = PlayerPrefs.GetInt("Coins");
        hp_prev = hp_current;
        start_position = GameObject.FindGameObjectWithTag("Start").GetComponent<StartPosition>();

        ESC_pannel_script = GetComponent<ESCPannelScript>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESC_pannel_script.ESC();
        }
        
        is_take_damage = IsTakeDamage();
        hp_prev = hp_current;

        if (hp_current <= 0)
        {
            Death();
        }
    }

    


    private bool IsTakeDamage()
    {
        return hp_current != hp_prev;
    }

    private void Death()
    {

        Destroy(gameObject);
        start_position.SpawnPlayer();
    }



}

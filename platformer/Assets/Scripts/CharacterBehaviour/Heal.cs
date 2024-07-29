using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    PlayerFullScript player_full_script;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        player_full_script = collider.GetComponent<PlayerFullScript>();
        if (player_full_script.hp_current < player_full_script.hp_max)
        {
            player_full_script.hp_current++;
        }
        Destroy(gameObject);
    }
}
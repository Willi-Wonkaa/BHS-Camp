using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerriesGetting : MonoBehaviour
{
    PlayerFullScript player_full_script;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        player_full_script = collider.GetComponent<PlayerFullScript>();
        player_full_script.coins++;
        Destroy(gameObject);
    }
}

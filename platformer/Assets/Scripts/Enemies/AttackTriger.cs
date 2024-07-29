using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackTriger : MonoBehaviour
{
    PlayerFullScript player_full_script;
    PlayerAnimation player_animation;
    private Sound sound => GetComponent<Sound>();

    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {

        sound.PlaySound(sound.sounds[0]);

        player_full_script = collider.GetComponent<PlayerFullScript>();
        player_animation = collider.GetComponent<PlayerAnimation>();

        player_animation._animator.SetBool("GetDamage", true);
        player_full_script.hp_current -= damage;
        Debug.Log(player_full_script.hp_current);
    }
}

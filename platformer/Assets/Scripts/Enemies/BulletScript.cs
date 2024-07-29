using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    PlayerFullScript player_full_script;
    PlayerAnimation player_animation;
    private Sound sound => GetComponent<Sound>();

    private float birth_time;
    public float live_time;

    public float horizontal_speed;
    public float vertical_speed;


    public void Awake()
    {
        birth_time = Time.time;
    }
    public void Update()
    {
        transform.position = new Vector2(transform.position.x + (horizontal_speed * Time.deltaTime), transform.position.y + (vertical_speed * Time.deltaTime));

        if (Time.time - birth_time > live_time)
        {
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        sound.PlaySound(sound.sounds[0]);

        player_full_script = collider.GetComponent<PlayerFullScript>();
        player_animation = collider.GetComponent<PlayerAnimation>();

        player_animation._animator.SetBool("GetDamage", true);
        player_full_script.hp_current -= 1;
        Debug.Log(player_full_script.hp_current);
        Death();
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPosition : MonoBehaviour
{
    public int current_lvl;
    public int max_avalable_lvl;

    public GameObject finish_pannel;
    public PlayerFullScript player_full_script;
    private Sound sound => GetComponent<Sound>();

    public void Awake()
    {
        finish_pannel.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        if (collider.gameObject.tag == "Player")
        {
            sound.PlaySound(sound.sounds[0]);
            player_full_script = collider.GetComponent<PlayerFullScript>();
            PlayerPrefs.SetInt("Coins", player_full_script.coins);
            Destroy(collider.gameObject);
            finish_pannel.SetActive(true);

            max_avalable_lvl = PlayerPrefs.GetInt("max_lvl");

            if (current_lvl+1 > max_avalable_lvl)
            {
                PlayerPrefs.SetInt("max_lvl", current_lvl+1);
            }
        }
    }
}

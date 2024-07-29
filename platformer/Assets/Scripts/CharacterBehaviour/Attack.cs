using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public EnemyScript enemy_script;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<EnemyScript>() != null)
        {
            enemy_script = collider.GetComponent<EnemyScript>();
            enemy_script.hp_cur -= 1;
            Debug.Log("player take 1 damage to " + collider.name);
        }
    }
}

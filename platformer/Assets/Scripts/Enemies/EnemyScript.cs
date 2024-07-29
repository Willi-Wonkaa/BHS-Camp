using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyScript : MonoBehaviour
{
    public int hp_max;
    public int hp_cur;

    public Animator _animator;



    public bool is_shooter;
    public GameObject bullet;
    public float attack_speed;
    private float last_attack_time;


    public void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Update()
    {
        _animator.SetBool("IsAttack", false);
        _animator.SetBool("IsHit", false);
        if (hp_cur <= 0)
        {
            Death();
        }

        if (is_shooter && (Time.time - last_attack_time) >= attack_speed)
        {
            last_attack_time = Time.time;
            Shoot(bullet);
        }

    }
    public void Death()
    {
        Destroy(gameObject);
    }

    public void Shoot(GameObject boollet)
    {
        _animator.SetBool("IsAttack", true);
        Instantiate(boollet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolScript : MonoBehaviour
{
    public List<Transform> patrul_positions = new List<Transform>();
    public float speed;

    private int cur_poss = 0;
    private int poss_list_len;

    private void Awake()
    {
        poss_list_len = patrul_positions.Count - 1;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrul_positions[cur_poss].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, patrul_positions[cur_poss].position) < 0.1f)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1; // Отзеркаливание по оси X
            transform.localScale = scale;
            if (cur_poss < poss_list_len)
            {
                cur_poss++;
            }
            else
            {
                cur_poss = 0;
            }
        }
    }
}

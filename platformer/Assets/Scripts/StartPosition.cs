using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{

    public GameObject player;

    public void Awake()
    {
        SpawnPlayer();
    }
    public void SpawnPlayer()
    {
        Instantiate(player, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}

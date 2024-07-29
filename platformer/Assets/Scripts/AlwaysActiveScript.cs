using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysActiveScript : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

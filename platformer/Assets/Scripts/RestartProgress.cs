using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartProgress : MonoBehaviour
{

    public void RestartProgress_()
    {
        PlayerPrefs.SetInt("max_lvl", 1);
        PlayerPrefs.SetInt("money", 0);
    }
}

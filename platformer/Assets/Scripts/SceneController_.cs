using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController_ : MonoBehaviour
{
    public int cur_lvl;

    public int max_avalible_lvl = 1;


    public void OpenLevelsWindow()
    {
        SceneManager.LoadScene("Levels");
    }

    public void OpenLvl_1()
    {
        max_avalible_lvl = PlayerPrefs.GetInt("max_lvl");
        SceneManager.LoadScene("Lvl_1");
        ChangeCurLvl(ref cur_lvl, 1);
    }
  
    public void OpenLvl_2()
    {
        max_avalible_lvl = PlayerPrefs.GetInt("max_lvl");
        if (max_avalible_lvl >= 2)
        {

            SceneManager.LoadScene("Lvl_2");
            ChangeCurLvl(ref cur_lvl, 2);
        }
    }
    public void OpenLvl_3()
    {
        max_avalible_lvl = PlayerPrefs.GetInt("max_lvl");
        if (max_avalible_lvl >= 3)
        {
            SceneManager.LoadScene("Lvl_3");
            ChangeCurLvl(ref cur_lvl, 3);
        }
    }
    public void OpenLvl_4()
    {
        max_avalible_lvl = PlayerPrefs.GetInt("max_lvl");
        if (max_avalible_lvl >= 4)
        {
            SceneManager.LoadScene("Lvl_4");
            ChangeCurLvl(ref cur_lvl, 4);
        }
    }
    public void OpenLvl_5()
    {
        max_avalible_lvl = PlayerPrefs.GetInt("max_lvl");
        if (max_avalible_lvl >= 5)
        {
            SceneManager.LoadScene("Lvl_5");
            ChangeCurLvl(ref cur_lvl, 5);
        }
    }

    public void OpenNextLvl()
    {
        SceneManager.LoadScene(cur_lvl+1);
    }
    public void RestartLvl()
    {
        SceneManager.LoadScene(cur_lvl);
    }
    
    private void ChangeCurLvl(ref int _cur_lvl, int lvl)
    {
        _cur_lvl = lvl;
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}

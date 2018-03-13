using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// @TODO : handle building level from TileMap

public class LevelManager : MonoBehaviour
{
    public int CurrentLevel = 1;
    public int PlayerDeaths = 0;

    void Start()
    {
        Screen.SetResolution(800, 600, false);
        LoadLevel(CurrentLevel);
    }
        
    /*
     * Load a level
     * If the scene doesn't exist, we congratulate the user on winning!
     * If it does, they keep playing!
     */
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level" + CurrentLevel);
        if (!SceneManager.GetSceneByName("Level" + CurrentLevel).IsValid())
        {
            Destroy(GameObject.Find("DeathsText"));
            SceneManager.LoadScene("GameOver");
        }
    }

    /*
     * Destroy the level
     */
    public void DestroyLevel()
    {
        Destroy(gameObject);
    }

    /*
     * Called when colliding with the key at the end of a level
     */
    public void IncrementLevelCounter()
    {
        CurrentLevel += 1;
    }

    public int GetCurrentLevel()
    {
        return CurrentLevel;
    }

    public void IncrementPlayerDeaths()
    {
        PlayerDeaths += 1;
    }

    public void UpdatePlayerDeathsText()
    {
        var text = GameObject.Find("DeathsText").GetComponent<Text>();
        text.text = "Deaths: " + PlayerDeaths;
    }
}
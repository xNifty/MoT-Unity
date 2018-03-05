using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// @TODO : handle building level from TileMap

public class LevelManager : MonoBehaviour
{
    private int _totalCoinsInLevel = 0;
    
    void Start ()
    {
        _totalCoinsInLevel = CountGameObjectsByTag("Coin");
        Debug.Log(_totalCoinsInLevel);
    }

    // Count the number of objects with a particular tag
    private int CountGameObjectsByTag(string objectTag)
    {
        return GameObject.FindGameObjectsWithTag(objectTag).Length;
    }

    public bool IsLevelComplete(int playerCoins)
    {
        // Eventually this'll open the gate guarding the door to next level
        if (_totalCoinsInLevel != playerCoins)
        {
            return false;
        }
        
        Debug.Log("Level complete!");
        return true;

    }

    private void ResetTotalCoins()
    {
        _totalCoinsInLevel = 0;
    }
}
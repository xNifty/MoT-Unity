using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	public int PlayerCoinCount;
	
	public void IncreaseCoinCount()
	{
		PlayerCoinCount += 1;
	}

	public int GetPlayerCoinCount()
	{
		return PlayerCoinCount;
	}
	
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

	public bool IsLevelComplete()
	{
		// Eventually this'll open the gate guarding the door to next level
		if (_totalCoinsInLevel != PlayerCoinCount)
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

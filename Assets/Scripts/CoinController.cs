using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinController : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
			other.gameObject.GetComponent<PlayerController>().IncreaseCoinCount();
			
			other.gameObject.GetComponent<PlayerController>().IsLevelComplete(
				other.gameObject.GetComponent<PlayerController>().GetPlayerCoinCount()
			);
		}
	}
}
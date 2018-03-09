using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyController : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Collided.");
		if (other.gameObject.CompareTag("Player"))
		{
			var levelManager = GameObject.Find("LevelManagement");
			var levelLoader = levelManager.GetComponent<LevelManager>();
			levelLoader.IncrementLevelCounter();
			levelLoader.LoadLevel(levelLoader.GetCurrentLevel());
		}
	}
}
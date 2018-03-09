using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public static void DeleteDoor()
	{
		GameObject[] doors;
		
		// Should also play door opening sound1
		doors = GameObject.FindGameObjectsWithTag("Door");
		foreach (GameObject door in doors)
		{
			Destroy(door);
		}
	}
}

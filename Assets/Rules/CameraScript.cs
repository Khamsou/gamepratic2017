using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	public GameObject currentRoom;

	// Use this for initialization
	void Start ()
	{
		GoToRoom("room1");
/*
		GameObject room = GameObject.Find("room1");
		zCorrectedRoomCenter = Vector3.Scale(room.transform.position, new Vector3(1, 1, 0)) + new Vector3(0, 0, -10);
		Camera.main.transform.position = zCorrectedRoomCenter;
*/
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	void GoToRoom(string roomName)
	{
		currentRoom = GameObject.Find(roomName);
		Vector3 zCorrectedRoomCenter = Vector3.Scale(currentRoom.transform.position, new Vector3(1, 1, 0)) + new Vector3(0, 0, -10);
		Camera.main.transform.position = zCorrectedRoomCenter;

		
	}

}

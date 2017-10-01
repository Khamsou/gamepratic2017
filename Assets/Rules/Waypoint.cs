using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : Node
{
	public Waypoint nextWaypoint;
	public Location loc;

	void Start()
	{

	}

	void OnMouseDown()
	{
		GoToNextPosition();
		print("Camera : " + Camera.main.transform.position);
	}

	void GoToNextPosition()
	{
		Vector3 zCorrectedRoomCenter = Vector3.Scale(nextWaypoint.loc.transform.position, new Vector3(1, 1, 0)) + new Vector3(0, 0, -10);
		Camera.main.transform.position = zCorrectedRoomCenter;
		print(nextWaypoint.gameObject.transform.position);
//		nextWaypoint.loc.gameObject.SetActive(true);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

	Vector3 lastMousePosition;
	float margin;
	Vector3 start;

	void Awake()
	{

	}

	// Use this for initialization
	void Start ()
	{
		start = transform.Find("Room1/startingPoint").gameObject.transform.position;
		margin = 0.05f;
	}
	
	// Update is called once per frame
	void Update ()
	{
//		if (start == null);
//			start = transform.Find("Room1/startingPoint").gameObject.transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		print("Entré dans le chemin");
		// mouse starting position
		lastMousePosition = Input.mousePosition;

		if (lastMousePosition.x < start.x + margin && lastMousePosition.x > start.x - margin && lastMousePosition.y < start.y + margin && lastMousePosition.y > start.y - margin)
			print("Started at starting point");
	}

	void OnTriggerStay2D(Collider2D other)
	{
//		if (Input.mousePosition.x > lastMousePosition.x)
//			print("good direction");

		lastMousePosition = Input.mousePosition;
	}

}

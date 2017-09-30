using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personnage : MonoBehaviour
{
	public List<Prop> cares;
	public int state;
	public string envState;

	// Use this for initialization
	void Start()
	{
		state = 0;
	}
	
	// Update is called once per frame
	void Update()
	{

	}

	public virtual void speak()
	{
		envState = "";

		foreach (Prop prop in cares)
			envState += prop.id + prop.state;
	}

}

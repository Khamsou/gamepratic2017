using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Node
{
	public enum Actions
	{
		DEFAULT,
		Discuter,
		FaireLit,
		SeCoucher,
		Repas1,
		Repas2,
		Repas3,
		RemplirGamelle,
		AllumerCheminee,
		EteindreCheminee,
		ServirRepas,
		AjouterHuile,
		AllumerLampe,
		EteindreLampe,
		InstallerLdC,
		RangerLdC,
		RetirerCroix
	};

	[System.Serializable]
	public struct StatesSprites
	{
		public Sprite ss1;
		public Sprite ss2;
		public Sprite ss3;
	}

	public Transform cameraPosition;
	public Location loc;
	[SerializeField]
	public Actions action;
	[SerializeField]
	public int id;
	public int state;
	[SerializeField]
	public StatesSprites sprites;

	void Awake()
	{

	}

	void OnMouseDown()
	{
		state = (++state)%3;

		print(state);
/*
		switch (action)
		{
			case Actions.Discuter:
				print(action.ToString());

				break;
			default:
				print("BWAAAAAAH");

				break;
		}
*/	}

}
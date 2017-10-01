using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Madeleine : Personnage {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		base.speak();
		ChoixDialogue dialogueLine;

		print(envState);

		switch (envState)
		{
			case "2010":
			case "2110":
			case "2210":
			case "2011":
			case "2111":
				dialogueLine = ChoixDialogue.accueil_0;			//manque texte

				break;
			case "2211":
				dialogueLine = ChoixDialogue.rappel_0;			//manque texte

				break;
			default:
				dialogueLine = ChoixDialogue.rappel_0;

				break;
		}

		FindObjectOfType<DialogSpawner>().setDialog(dialogueLine);
	}

}

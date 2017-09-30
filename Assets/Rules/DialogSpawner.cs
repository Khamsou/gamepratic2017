using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChoixDialogue{
	accueil_0,
	rappel_0,
	rencontre_0,
	adieu1_0,
	adieu2_0
}

public class DialogSpawner : MonoBehaviour {

	public static DialogSpawner Instance;
	public Transform Canvas;

	// Use this for initialization
	void Start () {
		Instance = this;
	}

	public void setDialog (ChoixDialogue dialogue) {
		DialogSpawner.Instance.InvoqueDialogue(dialogue);
	}

	public void InvoqueDialogue(ChoixDialogue dialogue){
		switch(dialogue){
			case ChoixDialogue.accueil_0:
				Instantiate(Resources.Load("Dialogs/accueil_0"), Canvas);			
				break;
		}
	}
}

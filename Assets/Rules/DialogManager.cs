using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Permet d'explorer la classe comme un fichier dans l'explorateur de Unity
[System.Serializable]
public class Dialogue{
	// Pour définir la taille de la zone de texte
	[TextArea(3,10)]
	public string Contenu;
}

public class DialogManager : MonoBehaviour {

	// Notre fidèle objet Texte
	public Text TexteCible;

	// Les dialogues enregistrés sur le gameObject/prefab en question
	public List<Dialogue> MesDialogues;

	private int _index;

	// Use this for initialization
	void Start () {
		_index = 0;
		// Dès que l'objet est instantié on appelle le premier dialogue
		AfficherLeProchainDialogue();
	}
	
	// Update is called once per frame
	void Update () {
		// Dialogue suivant
		if(Input.anyKeyDown){
			_index ++;
			if(_index >= MesDialogues.Count){
				// On destroy le dialogue lorsqu'on a lu tout le texte
				Destroy(gameObject);
				// On réinitialise le Game Mode
				FindObjectOfType<GameMode2>().setGameMode(0);

			}
			AfficherLeProchainDialogue();
		}
	}

	void AfficherLeProchainDialogue(){
		Dialogue leProchainDialogue = MesDialogues[_index];
		TexteCible.text = leProchainDialogue.Contenu;
	}
}

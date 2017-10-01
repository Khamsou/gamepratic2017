using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode2 : MonoBehaviour {

	public int CurrentGameMode;
	public string DialogueLine;
	public AudioClip Clang1C;
	private SoundManager _soundManager;
	private FadeBehaviour _fade;
	private FadeSpriteBehaviour _fadeSprite;
	private ChoixDialogue _thisDialogue;

	void Start() {
		CurrentGameMode = 0;
		_thisDialogue = (ChoixDialogue)System.Enum.Parse(typeof(ChoixDialogue), DialogueLine);
		_fade = FindObjectOfType<FadeBehaviour>();
		_fadeSprite = FindObjectOfType<FadeSpriteBehaviour>();
	}

	void Update() {

		if (CurrentGameMode == 0) {
			if(Input.anyKeyDown) {
				// change le mode de jeu pour ne pas cliquer n'importe où
				// setGameMode(1);
				// lance le dialogue
				// FindObjectOfType<DialogSpawner>().setDialog(_thisDialogue);
				// _soundManager.PlaySingleSound(Clang1C);
				// _fade.startFadeIn();
				_fadeSprite.startSpriteFadeIn();
			}
		}

	}

	// Dialogues = enum des différents dialogues disponibles
	public void setGameMode (int newMode) {
		CurrentGameMode = newMode;

		// 0 = Point'n'Click
		// 1 = Dialogue
		// 2 = Maintenir
		if (newMode == 1) {

		}
	}


}

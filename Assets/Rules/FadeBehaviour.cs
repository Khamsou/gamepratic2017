using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeBehaviour : MonoBehaviour {

	public float Speed = 8f;

	private float _opacity;
	private Image _image;
	private bool _fadeInEnCours;
	private bool _fadeOutEnCours;

	// Use this for initialization
	void Start () {
		_opacity = 0;
		_image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_fadeInEnCours) {
			fadeIn();
		} else if (_fadeOutEnCours) {
			fadeOut();
		}
	}

	public void startFadeIn() {
		_fadeInEnCours = true;
	}

	public void startFadeOut() {
		_fadeOutEnCours = true;
	}

	void fadeIn(){
		if (_opacity < 1) { 
			_opacity += .01f * Time.deltaTime * Speed;
			_image.color = new Color(0,0,0,_opacity);
		} else { _fadeInEnCours = false; }
	}

	void fadeOut(){
		if (_opacity > 0) { 
			_opacity -= .01f * Time.deltaTime * Speed;
			_image.color = new Color(0,0,0,_opacity);
		} else { _fadeOutEnCours = false; }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSpriteBehaviour : MonoBehaviour {

	public float Speed = 8f;

	private float _opacity;
	private SpriteRenderer _image;
	private bool _fadeInEnCours;
	private bool _fadeOutEnCours;

	// Use this for initialization
	void Start () {
		_opacity = 0;
		_image = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_fadeInEnCours) {
			spriteFadeIn();
		} else if (_fadeOutEnCours) {
			spriteFadeOut();
		}
	}

	
	public void startSpriteFadeIn() {
		_fadeInEnCours = true;
	}
	
	public void startSpriteFadeOut(string gameObjectName) {
		if (gameObjectName == transform.gameObject.name) {
			_fadeOutEnCours = true;
		}
	}

	void spriteFadeIn(){
		if (_opacity < 1) { 
			_opacity += .01f * Time.deltaTime * Speed;
			_image.color = new Color(1,1,1,_opacity);
		} else { _fadeInEnCours = false; }
	}

	void spriteFadeOut(){
		if (_opacity > 0) { 
			_opacity -= .01f * Time.deltaTime * Speed;
			_image.color = new Color(1,1,1,_opacity);
		} else { _fadeOutEnCours = false; }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute_Game : MonoBehaviour {

	bool IsMuted;

	void Awake(){
		AudioListener.volume = PlayerPrefs.GetFloat("Mute_Volume");

	}

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		AudioListener.volume = PlayerPrefs.GetFloat ("Mute_Volume");

		if (Input.GetKeyDown (KeyCode.M)) {
			Mute();

		}
	}

	void Mute ()
	{
		IsMuted = !IsMuted;

		if (IsMuted) {
			PlayerPrefs.SetFloat ("Mute_Volume", 0);

		}

		if (!IsMuted) {
			PlayerPrefs.SetFloat("Mute_Volume",1);

		}

	}
}

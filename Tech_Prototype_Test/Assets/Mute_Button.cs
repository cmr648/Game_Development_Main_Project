using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute_Button : MonoBehaviour {

	bool IsMuted;

	void Awake(){ // a function that happens before start
		AudioListener.volume = PlayerPrefs.GetFloat("Mute_Volume"); // on awake making sure our audio listenr remembers the player preference of mute
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	AudioListener.volume = PlayerPrefs.GetFloat("Mute_Volume"); // always checking for the mute toggle

	}

	public void Mute ()
	{
		IsMuted = !IsMuted; // making is muted be the opposite

		if (IsMuted) { // checking to see if the toggle is set to bieng muted
		PlayerPrefs.SetFloat("Mute_Volume",0); // turning our volume off

		}

		if (!IsMuted) { // checking if the toggle is set to bieng un muted
		PlayerPrefs.SetFloat("Mute_Volume",1); // turning our volume all the way on

		}
	}

}

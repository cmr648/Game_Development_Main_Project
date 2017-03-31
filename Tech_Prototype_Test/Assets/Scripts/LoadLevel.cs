using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // using the unity engine UI Component


public class LoadLevel : MonoBehaviour {

public Animator Fader_Animator; // creating a reference to the faders animator
public Image Fader; // creating a reference to the image fader 

public AudioSource Background_Music; // creating a public reference to our audio source



//public Image Fader; // creating a reference to our fader image object
//public Animator Fader_animator; // creaing a public reference to our fader animator

public string NextScene; // Creating a public scene to change the next scene we go to 

	GameObject Sound_Manager; // Creating a public gameobject reference to our sound manager
	public AudioClip Load_Level_Audio; // Creating a public audio clip for load level

	// Use this for initialization
	void Start () {
	Debug.Log(Fader.GetComponent<Image>().color.a); // logging our fader component to check its alpha
	Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager"); // Finding the sound Manager
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Fader_Animator.GetBool ("Fade") == true) { // checking to see if in the animator our fade transition bool is ewual to true
		Check_for_Black(); // then we can use our check for black function
		Background_Music.volume -= .55f*Time.deltaTime; // fading out out our song
		}

		
	}

	public void LevelLoad (){ // creating a public void to accesss in a UI button
		Fader_Animator.SetBool("Fade",true); // setting our animator boolean variable to be equal to true
		//SceneManager.LoadScene(NextScene);  // loading a new scene in which we enter the scene publicly
		Sound_Manager.GetComponent<Sound>().Playsound(Load_Level_Audio,1); // playing the Load_Level_Sound
	}

	public void QuitGame (){ // creating a public void for our quit game function
		Application.Quit(); // quitting the application on this void
	}

	 void Check_for_Black (){ // creating a void to check if we have completely faded out
		if (Fader.GetComponent<Image> ().color.a == 1) {  // checking to see if our faders colors alpha value is equal to 1
			SceneManager.LoadScene(NextScene);  // loading a new scene in which we enter the scene publicly
		}

	}

}

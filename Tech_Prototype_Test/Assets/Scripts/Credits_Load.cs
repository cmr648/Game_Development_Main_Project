using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits_Load : MonoBehaviour {

	public GameObject Start_Game_Button; // a public gameobject reference to our start game button
	public GameObject Quit_Game_Button; // Creating a public gameobject reference to our quit game button
	public GameObject Instructions_Show_Button; // Creating a public gameobejct reference to our instructions show button
	public GameObject Credits_Panel; // Creating a public gameobject reference to our credits panel
	public GameObject Credits_Button; // creating a public gameobject reference to ourselves

	GameObject Sound_Manager; // Creating a public gameobject reference to our sound manager
	public AudioClip Load_Level; // Creating a public audio clip for load level
	public AudioClip Hide_UI; // Creating a public gameobject for hide ui
	public AudioClip Show_UI; // creating a public gameobject for show ui




	// Use this for initialization
	void Start () {
	Credits_Panel.SetActive(false); // turning our credits panel off at the start of the game
	Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager"); // Finding the sound Manager

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Show_Credits(){ // creating a public void to show the credits and hide everything else
	Credits_Panel.SetActive(true); // Setting our credits panel to be on
	Start_Game_Button.SetActive(false); // Setting our Start game button to be off
	Quit_Game_Button.SetActive(false); // Setting our Quit game button to be off
	Instructions_Show_Button.SetActive(false); // setting our instructions button to be off
	Credits_Button.SetActive(false); // setting our credits button to be off
	Sound_Manager.GetComponent<Sound>().Playsound(Show_UI,1); // playing the show ui sound

	}

	public void Hide_Credits(){ // Creatinga  public void to hide the credits and show everything else
	Credits_Panel.SetActive(false); // setting oru credits panel to be off
	Start_Game_Button.SetActive(true); // settting our start game button to be on
	Quit_Game_Button.SetActive(true); // setting our quit game button to be on
	Instructions_Show_Button.SetActive(true); // setting our instructions show button to be on
	Credits_Button.SetActive(true); // setting our credits button to be on
	Sound_Manager.GetComponent<Sound>().Playsound(Hide_UI,1); // playing the Hide ui sound
	}


}

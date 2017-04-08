using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // we will be using a unity engine ui component for our instructions panel

public class Instructions_Load : MonoBehaviour {

	public GameObject Instructions_Panel; // setting up a public gameobject for our instructions panel
	public GameObject Start_Game_Button; // setting up a public gameobject for our start game button
	public GameObject Instructions_Show_Button; // setting up a public gameobject for our showing instructions show button
	public GameObject Quit_Game_Button; // setting up a public game object for our quit game button
	public GameObject Show_Credits_Button; // Setting up a public game object for our show credits button
	public GameObject Mute_Button; // settting up a public game object reference for our mute button

	GameObject Sound_Manager; // Creating a public gameobject reference to our sound manager
	public AudioClip Load_Level; // Creating a public audio clip for load level
	public AudioClip Hide_UI; // Creating a public gameobject for hide ui
	public AudioClip Show_UI; // Creating a public gameobejct for show ui

	// Use this for initialization
	void Start () {
	Instructions_Panel.SetActive(false); //at the start of our game setting our instructions panel to be off 
	Start_Game_Button.SetActive(true); // at the start of the game setting our start game button to be active and shown
	Instructions_Show_Button.SetActive(true); // at the start of the game setting our instructions shwowing button to be active and shown
	Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager"); // Finding the sound Manager
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Load_Instructions(){ // creating a void to load instructions

	Instructions_Panel.SetActive(true); // setting our instructions panel to be visible
	Start_Game_Button.SetActive(false); //setting our start game button to be invisible
	Instructions_Show_Button.SetActive(false); // setting our instructions show button to be invisible
	Quit_Game_Button.SetActive(false); // setting our start game button to be invisible
	Show_Credits_Button.SetActive(false); // setting our show credits button to be off
	Mute_Button.SetActive(false); // setting our mute button to be off

	Sound_Manager.GetComponent<Sound>().Playsound(Show_UI,1); // playing the show ui sound

	}

	public void Hide_Instructions () { // creating a void to hide the instructions panel
	Instructions_Panel.SetActive(false); // setting our instructions panel to be invisible
	Start_Game_Button.SetActive(true); // setting our start game button to be visible
	Instructions_Show_Button.SetActive(true); // setting our instructions show button to be visible
	Quit_Game_Button.SetActive(true); // setting our quit game button to be visible
	Show_Credits_Button.SetActive(true); // setting our show credits button to be on
	Mute_Button.SetActive(true); // turning our mute button back on

	Sound_Manager.GetComponent<Sound>().Playsound(Hide_UI,1); // playing the Hide ui sound


	}
}

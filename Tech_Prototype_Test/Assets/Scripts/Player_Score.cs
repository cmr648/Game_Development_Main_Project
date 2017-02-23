using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // we will be using unity engine.ui for this

public class Player_Score : MonoBehaviour {

	

	public Text playertext; // creating player text to edit
	public Text High_Score_Text; // Creating a high score text to edit

	// Use this for initialization
	void Start () {

	playertext.text = "Your Score: " + PlayerPrefs.GetFloat("CurrentScore"); // assinging the players last score to the player text

	High_Score_Text.text = "High Score: " + PlayerPrefs.GetFloat("Highscore"); //assinging the high score variable to our text

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure_Pickup : MonoBehaviour {

	float Player_Score; // creating a float for our player score
	public float treasureUP; // Creating a float for how much a piece of treasure raises the score by
	public Text playertext; // creating a public variable for player text

	// Use this for initialization

	void Start () {

	Player_Score = 0; // setting the player score to 0 at the start of the game

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate (){ // an update function that is called every frame
		playertext.text = "Score: " + Player_Score; //adding our player score to the text field every frame
		PlayerPrefs.SetFloat("CurrentScore", Player_Score);// setting our player score to be saved between levels

	}

	void OnCollisionEnter2D (Collision2D col)
	{ // a void that checks to see if a gameobject has collided with something

		if (col.gameObject.tag == "Treasure") { // checking to see if the plaer has collided with an average piece of treasure
		Destroy(col.gameObject); // get rid of the piece of treasure
		Player_Score = Player_Score + treasureUP; // adding treasure up to the player score once
		}

	}
}

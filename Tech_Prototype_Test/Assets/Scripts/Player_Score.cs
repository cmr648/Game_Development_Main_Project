using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // we will be using unity engine.ui for this

public class Player_Score : MonoBehaviour {

	

	Text playertext; // creating player text to edit

	// Use this for initialization
	void Start () {

	playertext = gameObject.GetComponent<Text>(); // getting the text component of our gameobject
	playertext.text = "Your Score: " + PlayerPrefs.GetFloat("CurrentScore"); // assinging the players last score to the player text

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

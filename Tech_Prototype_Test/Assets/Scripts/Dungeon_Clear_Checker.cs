using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dungeon_Clear_Checker : MonoBehaviour {

	public static float Enemy_Amount; //creating a public variable for enemy amount
	public float Enemy_Amount_Check; // creating a check variable to see if enemy amount is correct 
	public GameObject Game_End_Panel; // creating a public game object for our game end panel 

	// Use this for initialization
	void Start () {
	Game_End_Panel.SetActive(false); // turning our game panel off at the start of the level

	}
	
	// Update is called once per frame
	void Update () {
		Enemy_Amount_Check = Enemy_Amount; // setting the enemy amount check to the enemy amount
		if (Enemy_Amount <= 0) { // checking to see if the dungeon is cleared of enemies
			Game_End_Panel.SetActive(true); // turning our game end panel on

		}
	}

	void FixedUpdate ()
	{ // an update function that is called every frame instead of every rendered frame

		

	}

}

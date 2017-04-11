using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dungeon_Clear_Checker : MonoBehaviour {

	public static float Enemy_Amount; //creating a public variable for enemy amount
	public float Enemy_Amount_Check; // creating a check variable to see if enemy amount is correct 
	public GameObject Game_End_Panel; // creating a public game object for our game end panel 

	public Text Level_Text; // A text that shows what level is currently happneing
	float Current_Level; // A number that will track what level it is on

	// Use this for initialization
	void Start () {
	Level_Text.enabled = false; // disableing the level text at the start of the game
	Current_Level = -1; // setting the current level to one
	Game_End_Panel.SetActive(false); // turning our game panel off at the start of the level
	StartCoroutine("Show_Level");
	}
	
	// Update is called once per frame
	void Update () {
		Enemy_Amount_Check = Enemy_Amount; // setting the enemy amount check to the enemy amount
		if (Enemy_Amount <= 0) { // checking to see if the dungeon is cleared of enemies
			//Game_End_Panel.SetActive(true); // turning our game end panel on
			StartCoroutine("Show_Level");
		}

	}

	void FixedUpdate ()
	{ // an update function that is called every frame instead of every rendered frame

		Level_Text.text = "Level: " + Current_Level; // setting the level text

	}

	IEnumerator Show_Level (){ // creating an IEnumerator to show the level
		Current_Level = Current_Level +1;
		Level_Text.enabled = true;
		yield return new WaitForSeconds(1f);
		Level_Text.enabled = false;
		yield return new WaitForSeconds(1f);
		Level_Text.enabled = true;
		yield return new WaitForSeconds(1f);
		Level_Text.enabled = false;
		yield return new WaitForSeconds(1f);
		Level_Text.enabled = true;
		yield return new WaitForSeconds(1f);
		Level_Text.enabled = false;

	}



}

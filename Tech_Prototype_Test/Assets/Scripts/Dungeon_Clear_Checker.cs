using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dungeon_Clear_Checker : MonoBehaviour {

	public static float Enemy_Amount; //creating a public variable for enemy amount
	public float Enemy_Amount_Check; // creating a check variable to see if enemy amount is correct 
	public string Next_Level; // creating a public string to choose the next level

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		Enemy_Amount_Check = Enemy_Amount; // setting the enemy amount check to the enemy amount
		if (Enemy_Amount <= 0) { // checking to see if the dungeon is cleared of enemies
			SceneManager.LoadScene(Next_Level); // loading the next level after the dungeon is cleared

		}
	}

	void FixedUpdate ()
	{ // an update function that is called every frame instead of every rendered frame

		

	}

}

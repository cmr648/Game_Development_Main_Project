using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_Scaling : MonoBehaviour {

	public GameObject Health_Bar; // creating a public gameobject for the healthbar 
	public float Player_Total_Health; // creating a public float to calcualte and change the total player health
	public float Player_Current_Health; // creating a public float to calcualte and change the total player health
	public float Player_Health_Boost; // creating a public float to calculate the health boost that will be added to the player health
	public float Player_Damage; // creating a public variable for player damage that the player will take;

	// Use this for initialization
	void Start () {
		Player_Current_Health = Player_Total_Health; // setting the players current health to be equal to the players current health at the start of the game
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){ // an update function taht is called every frame instead of every rendered frame
		Health_Bar.transform.localScale = new Vector3 ((Player_Current_Health/Player_Total_Health),1,1); // changing the scale of the health bar to change when taking damage
		Damage_Bounds(); // implementing our damage bounds function
		Game_Over_Check(); // implementing game over check
	}

	void OnCollisionEnter2D (Collision2D col)
	{ //checking to see if the player is colliding with an object

		if (col.gameObject.tag == "Enemy") { // checking to see if the player is colliding with an enemy game object
			Player_Current_Health -= Player_Damage; // subtracting the player damage from the health bar
		}

		if (col.gameObject.tag == "Health_Boost") { // checking to see if the player is colliding with a health boost game object
			Player_Current_Health += Player_Health_Boost; // adding the player health boost to the health bar
			Destroy(col.gameObject); // get rid of the health pack upon using it one time
		}

	}

	void Damage_Bounds ()
	{ //creating our damage bounds function
		if (Player_Current_Health <= 0) { // checking to see if the player health is less than or equal to 0;
			Player_Current_Health = 0; // resetting the player health to be 0 so the health bar wont go backwards
		}

		if (Player_Current_Health >= Player_Total_Health) { // checking to see if the player health is greater than or equal to the player total health
			Player_Current_Health = Player_Total_Health; // resetting the player health to be 0 so the health bar wont go to far
		}
		
	}

	void Game_Over_Check ()
	{ // creating our game over check function
		if (Player_Current_Health == 0) { // checking to see if player health = 0
		SceneManager.LoadScene("Game_Over"); // loading our game over screen if the player health = 0
		}

	}


}

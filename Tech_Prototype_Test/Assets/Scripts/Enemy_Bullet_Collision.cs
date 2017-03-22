using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Collision : MonoBehaviour {

	public GameObject Sound_Manager; // creating a public gameobject reference for our sound manager
	public AudioClip Wall_Hit_Audio; // creating a public gameobject reference to our wall hit audio clip

	// Use this for initialization
	void Start () {

	Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{ //a void that checks to see if the bullet has encoutered a collider
		if (col.gameObject.tag == "Wall") { // checking to see if the bullet has encoutered a wall object
			Destroy (gameObject); // making the bullet destroy itself
			//Sound_Manager.GetComponent<Sound>().Playsound(Wall_Hit_Audio,1); // playing our wall hit sound
		}

		if (col.gameObject.tag == "Health_Boost") { //checking to see if the bullet is colliding with a heatlh pack
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Treasure") { //checking to see if the bullet is colliding with a Treasure
			Destroy (gameObject); // making the bullet destroy itself
		}

	

	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the players is colliding with the left
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the players is colliding with the right
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the players is colliding with the Top
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the players is colliding with the Bottom
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Bullet_Destroy") { // checking to see if the enemy bullet is hitting a bullet destroy trigger
			Destroy(gameObject); // destroy the enemy bullet

		}


	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

	public float Start_Health; // the health that an enemy will start with
	float Half_Health;
	SpriteRenderer Enemy_Renderer; // Creating a variable to get the renderer of the enemy game object

	// Use this for initialization
	void Start () {

	Enemy_Renderer = GetComponent<SpriteRenderer>(); // assigning the players sprite renderer to the enemy renderer at the start of the game
	Half_Health = Start_Health/2; // setting half health to be half the player health
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () // an update function that is called every frame
	{
		if (Start_Health <= Half_Health) { // checking to see if the enemy health is less than or equal to 2
			Enemy_Renderer.color = Color.red; // assinging the red color to the enemy
		}

		if (Start_Health <= 0) { // checking to see if the enemy has no life left
		Destroy(gameObject); // destroy the enemy game object
		}

	}

	void OnCollisionEnter2D (Collision2D col)	{ // a void that checks to see if the enemy collided with soething
		if (col.gameObject.tag == "Player_Bullet") { // checking to see if the collision was with a player bullet
			Start_Health -= 1; // make the enemy lose health
			Destroy(col.gameObject);// destroyt the player bullet
		}


	}
}

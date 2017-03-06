using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Random_Movement : MonoBehaviour {

	public float Move_Speed_X_Limit;//creating a limit for the x speed random
	public float Move_Speed_Y_Limit; // creating a limit for the x speed random
	float Move_Speed_X;  // creating a move speed x float
	float Move_Speed_Y;  // creating a move speed y float
	Vector3 Velocity; //creating a vector for velocity

	// Use this for initialization
	void Start () {
		
		Move_Speed_X = Random.Range(-Move_Speed_X_Limit,Move_Speed_X_Limit); // setting move speed x to be a random range to the limit we oursevels set
		Move_Speed_Y = Random.Range(-Move_Speed_Y_Limit,Move_Speed_Y_Limit); // setting move speed y to be a random range to the limit we oursevels set
		Velocity = new Vector3(Move_Speed_X,Move_Speed_Y,0); // Setting velocity to a new vector 3 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){ // an update function that lasts every frame instead of every rendered frame
		gameObject.transform.position += Velocity; // moving the gameobject by the velocity every frame

	}

	void OnCollisionEnter2D (Collision2D col)
	{ // checking to see if the gameobject has collided with something
		if (col.gameObject.tag == "Wall" || col.gameObject.tag == "Enemy") { // checking to see if the gameobject that our gameobject is colliding with is a wall
			Velocity = -Velocity; // reversing the velocity of the gameobject

		}

		if (col.gameObject.tag == "Final_Boundry") { //checking to see if the col.gameobject is the final boundry
			Destroy(gameObject); // destroy the cube
			Dungeon_Clear_Checker.Enemy_Amount = Dungeon_Clear_Checker.Enemy_Amount-1; //subtracing the enemy value from the dungeon clear checker
		}

	}
}

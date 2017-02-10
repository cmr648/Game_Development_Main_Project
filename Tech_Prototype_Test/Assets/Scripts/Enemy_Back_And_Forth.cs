using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Back_And_Forth : MonoBehaviour {

	public float MoveSpeedX; // Creating a public float for the speed of our objects
	public float MoveSpeedY; // Creating a public float for the speed of our objects
	Vector3 Velocity; //creating a vector for velocity

	// Use this for initialization
	void Start () {
		Velocity =  new Vector3(MoveSpeedX,MoveSpeedY,0); // assinging our movespeeds to our vector
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void FixedUpdate(){
		gameObject.transform.position += Velocity;  // adding our velocity to the gameobject
	}

	void OnCollisionEnter2D (Collision2D col)
	{ // a funciton that checks to see if a gameobject has collided with something

		if (col.gameObject.tag == "Wall" || col.gameObject.tag == "Enemy") { // if the gameobject hits a wall or another enemy
		Velocity = -Velocity; // reverse its velocity

		}

	}
}

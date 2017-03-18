using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour {
	public static float Move_Speed = .2f; // Creating a public gameobject to calculate the speed we want the bullet to move at
	 Rigidbody2D rb; // creating a rigidbody 2d variable to set later

	// Use this for initialization
	void Start ()
	{
		if (Move_Speed < 0) { // if move speed is a negative number
		Move_Speed = -Move_Speed; // making move speed a positive number
		}
		rb = GetComponent<Rigidbody2D>(); // setting our rigidbody variable
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void FixedUpdate (){ // a void that will allow a command to be called on a timestamp instead of every rendered frame
		Debug.Log((Geo.ToVector3(transform.eulerAngles.z) * Move_Speed)); // checking the move speed
		rb.MovePosition(transform.position + (Geo.ToVector3(transform.eulerAngles.z) * Move_Speed)); // moving the position of the rigid body based on the angle of the player

	}

}

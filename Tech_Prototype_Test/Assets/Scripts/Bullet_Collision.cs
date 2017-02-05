using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) { //a void that checks to see if the bullet has encoutered a collider
		if (col.gameObject.tag == "Wall") { // checking to see if the bullet has encoutered a wall object
			Destroy(gameObject); // making the bullet destroy itself
		}

	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the players is colliding with the left
			Destroy(gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the players is colliding with the right
			Destroy(gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the players is colliding with the Top
			Destroy(gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the players is colliding with the Bottom
			Destroy(gameObject); // making the bullet destroy itself
		} 



	}
}
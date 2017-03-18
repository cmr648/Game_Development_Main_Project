using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision_Original : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) { //a void that checks to see if the bullet has encoutered a collider
		if (col.gameObject.tag == "Wall") { // checking to see if the bullet has encoutered a wall object
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy(gameObject); // making the bullet destroy itself
			Destroy(gameObject.GetComponentInParent<GameObject>());

		}

		if (col.gameObject.tag == "Health_Boost") { //checking to see if the bullet is colliding with a heatlh pack
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Treasure") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}

		if (col.gameObject.tag == "BulletSpeedUp") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}
		if (col.gameObject.tag == "BulletSpeedDown") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}

		if (col.gameObject.tag == "BulletSizeUp") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}

		if (col.gameObject.tag == "BulletSizeDown") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}

	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the bullet is colliding with the left
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the bullet is colliding with the right
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the bullet is colliding with the Top
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the bullet is colliding with the Bottom
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		} 



	}
}
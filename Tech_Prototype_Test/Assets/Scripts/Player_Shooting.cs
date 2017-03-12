using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

	public GameObject Bullet; // Creating a public game object to add our bullet prefab
	public GameObject Bullet_Spawn_Position; // Creating a public game object to set our bullet spawn position to
	public float Bullet_Time; // Cretaing a delay that the bullets will be fired upon
	SpriteRenderer bullet_renderer; // creating a bulletrenderer to take the sprite renderer of the bullet and edit it
	Vector3 bulletSpawnPositionEdit;

	Vector3 bulletNormalSize = new Vector3 (2.0f,2.0f,2.0f); // creating a vector3 for the bullet normal size
	Vector3 bulletHalfSize = new Vector3(1.8f,1.8f,1.8f); // creating a vector3 for bullet half size
	Vector3 bulletDoubleSize = new Vector3(2.3f,2.3f,2.3f); // creating a vector3 for bullet double size
	public float bulletSlow; // creating a float for our bullet on the slow powerup
	public float bulletFast; // creating a float for our bullet on the slow powerup



	// Use this for initialization
	void Start () {

		bullet_renderer = Bullet.GetComponentInChildren<SpriteRenderer>(); // getting the sprite renderer of our bullet and applying it to the bullet renderer

		bulletSpawnPositionEdit = new Vector3 (Bullet_Spawn_Position.transform.position.x, Bullet_Spawn_Position.transform.position.y, Bullet_Spawn_Position.transform.position.z+10); // setting the bullet spawn position every time a bullet is instantiated

		bullet_renderer.color = Color.white; // setting the bullet to be white at the start of the game
		Bullet.transform.localScale = bulletNormalSize; // setting the bullet to be normal size at the start of the game
		}
	
	// Update is called once per frame
	void Update ()
	{

			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.A)) { // an if statement that checks to see if the WSAD keys have been pressed

				InvokeRepeating ("Fire_Bullet", 0, Bullet_Time); // repeating our fire bullet function to make the player fire on a delay

			}

			if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) { // if our keys are not bieng pressed it will cancel the invoke
				CancelInvoke (); // cancel the invoke repeating method
			}

	}

	void Fire_Bullet(){ // creating our fire bullet function
		Instantiate(Bullet, Bullet_Spawn_Position.transform.position, transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed

	}


	void OnCollisionEnter2D (Collision2D col)
	{ // a function that checks to see if the player has collided with something

//		if (col.gameObject.tag == "BulletSpeedUp") { // if the player has collided with an arrow pickup 
//		Destroy(col.gameObject); // remove the pickup
//		}
//
//
//		if (col.gameObject.tag == "BulletSpeedDown") { // if the player has collided with an arrow pickup 
//		Destroy(col.gameObject); // remove the pickup
//		}

		if (col.gameObject.tag == "BulletSizeUp") { // if the player has collided with an arrow pickup 
		Destroy(col.gameObject); // remove the pickup
		Bullet.transform.localScale = bulletDoubleSize; // changing the size of the bullet to be twice as large
		Bullet_Movement.Move_Speed = bulletSlow; // changing the speed of the bullet to be half speed
		bullet_renderer.color = Color.cyan; //changing the color of the bullet
		}

		if (col.gameObject.tag == "BulletSizeDown") { // if the player has collided with an arrow pickup 
		Destroy(col.gameObject); // remove the pickup
		Bullet.transform.localScale =  bulletHalfSize;  // changing the size of the bullet to be half
		Bullet_Movement.Move_Speed = bulletFast; // changing the speed of the bullet to be *2
		bullet_renderer.color = Color.magenta; // changing the color of the bullet
		}




	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour {

	public static float Bullet_Life; // creating a public float for bullet life

	GameObject Sound_Manager; // creating a public gameobject reference to our sound manager
	public AudioClip[] Skeleton_Sound; // Creatinga  public gameobject reference to our list of skeleton sounds


	// Use this for initialization
	void Start () {

	Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager");

	Bullet_Life = 3; // setting our initial value for bullet life
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate (){ // an update function that runs every frame instead of every rendered frame
		if (Bullet_Life <= 0) { // checking to see if the bullet life is empty
		Destroy(gameObject); // delete the bullet
		Player_Shooting.Bullet_Limit -=1; // subtracting one from out bullet limit
		//Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed; // reversing our bullet speed
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{ //a void that checks to see if the bullet has encoutered a collider
		if (col.gameObject.tag == "Wall") { // checking to see if the bullet has encoutered a wall object
			GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed; // reversing our bullet speed
			//Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			//	Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			//Bullet_Life = Bullet_Life - 1; // subtract 1 from bullet life
		}


		if (col.gameObject.tag == "Enemy") { // checking to see if the player has hit an enemy
			GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed; // reversing our bullet speed
			//	Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			//	Bullet_Life = Bullet_Life - 1; // subtract 1 from bullet life
			//Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			//GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed; // reversing our bullet speed
		}

		if (col.gameObject.tag == "Player_Bullet") { // checking to see if it hits another player bullet object
			//GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed; // reversing our bullet speed
			Physics2D.IgnoreCollision (gameObject.GetComponent<Collider2D> (), col.gameObject.GetComponent<Collider2D> ());
		}

		if (col.gameObject.tag == "Player") {
			Destroy (gameObject); // destroying the gameobject
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limit
			//Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed; // reversing our bullet speed
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

		if (col.gameObject.tag == "BulletSizeNormal") { //checking to see if the bullet is colliding with a Treasure
			Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			Destroy (gameObject); // making the bullet destroy itself
		}


		//DOING STUFF WITH SOUND

		if (col.gameObject.tag == "Skeleton") { // checking to see if the gameobject has hit a skeleton
			GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement> ().Player_Bullet_Move_Speed; // reversing our bullet speed
			Sound_Manager.GetComponent<Sound>().Playsound(Skeleton_Sound[Random.Range(0,Skeleton_Sound.Length)],1); // playing a random sound of our skeleton sounds list
		}


	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the bullet is colliding with the left
			//Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			//Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the bullet is colliding with the right
		//	Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
		//	Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the bullet is colliding with the Top
		//	Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			//Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the bullet is colliding with the Bottom
		//	Player_Shooting.Bullet_Limit -= 1; // subtracting one from our bullet limt
			//Destroy (gameObject); // making the bullet destroy itself
		} 

		if (col.gameObject.tag == "Physics_Stop") { // checking to see if the bullet is colliding with a physics stop object
			Destroy(gameObject); // destroying the gameobject
			Player_Shooting.Bullet_Limit -=1; // subtracting one from our bullet limit
			//Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing our bullet speed
			GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed = -GetComponent<Bullet_Movement>().Player_Bullet_Move_Speed; // reversing our bullet speed
		}

	}
}
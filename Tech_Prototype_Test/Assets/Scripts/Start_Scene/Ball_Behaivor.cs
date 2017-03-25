using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball_Behaivor : MonoBehaviour {


	float Ball_Gravity_Collision = 2; // This float is ultimately usless but is a good reference number for me too look at
	Vector3 Ball_Velocity = new Vector3 (4.0f,-4.0f,0); // Creating the velocity that will be shifted thrgouthout the program for the ball



	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<Rigidbody2D>().velocity = Ball_Velocity; // this is just a simple line that will constantly be adding velocity to the ball every frame in order for the game to begin

	}


	void FixedUpdate(){ // an update function taht runs every frame instead of every rendered frame
		GetComponent<Rigidbody2D>().velocity = Ball_Velocity; // this is just a simple line that will constantly be adding velocity to the ball every frame in order for the game to begin

	}

	void OnCollisionEnter2D (Collision2D col)
	{ //A void created for detecting collision in unity that we will create our bounce script with



		if (col.gameObject.name == "Camera_Wall_Down") { // a collision script specifically tiered to the downwards Wall
			Ball_Velocity.y = -1 * (Ball_Velocity.y); // this reverses the balls velocity every time it hits the downward wall
		}
		if (col.gameObject.name == "Camera_Wall_Up") { // a collision script specifically tiered to the upwards Wall
			Ball_Velocity.y = -1 * (Ball_Velocity.y); // this reverses the balls velocity every time it hits the upwards wall
		}	
		if (col.gameObject.name == "Camera_Wall_Left") { // a collision script specifically tiered to the left Wall
			Ball_Velocity.x = -1 * (Ball_Velocity.x); // this reverses the balls velocity every time it hits the left wall
		}
		if (col.gameObject.name == "Camera_Wall_Right") { // a collision script specifically tiered to the right Wall
			Ball_Velocity.x = -1 * (Ball_Velocity.x); // this reverses the balls velocity every time it hits the right wall
		}


		}


//		if (gameObjectHittingMe.gameObject.name == "Brick") { // a collision script specifically tiered to the paddle
//		Ball_Velocity = -1*(Ball_Velocity); // this reverses the balls velocity every time it hits the paddle
//		Destroy(gameObjectHittingMe.gameObject); // this should destroy a brick upon collision
//
//		}

		}


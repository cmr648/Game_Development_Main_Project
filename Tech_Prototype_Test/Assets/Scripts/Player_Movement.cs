using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
	public float playerspeed; //creating a variable that will function as the speed our player will move at

	Rigidbody2D rb; // creating a rb variable to get the players rigidbody2d

	Vector2 PlayerInput; // Creating a vector2 to adjust on player input
	Vector2 currentPlayerPos; //Creating a vector 2 for the current player position

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>(); // setting our rb variable to the current rigidbody of the player
	}
	
	// Update is called once per frame
	void Update ()
	{
		ArrowKeyMovement(); // implementing our player movement function
	}

	void FixedUpdate(){ // an update function that runs on a time stamp rather than every rendered frame
		currentPlayerPos = new Vector2(transform.position.x,transform.position.y); // resetting the current player position on fixed update
		rb.MovePosition(currentPlayerPos + PlayerInput*playerspeed); //moving the position of the player every time

	}

	void ArrowKeyMovement ()
	{ //creating a void to register commands to the arrow keys
		PlayerInput = Vector2.zero;
		if (Input.GetKey (KeyCode.UpArrow)) { // checking to see if the up arrow key has been pressed
			PlayerInput += new Vector2 (0,1); // setting the player input vector 2 to the up direction
			transform.eulerAngles = new Vector3 (0,0,90); // Changing the angle of our player to be facing up 
		} 
		if (Input.GetKey (KeyCode.DownArrow)) { // checking to see if the down arrow key has been pressed
			PlayerInput += new Vector2(0, -1); // setting the player input vector 2 to the down direction
			transform.eulerAngles = new Vector3 (0,0,-90); // Changing the angle of our player to be facing down 
		}
		if (Input.GetKey (KeyCode.LeftArrow)) { // checking to see if the left arrow key has been pressed
			PlayerInput += new Vector2(-1, 0); // setting the player input vector 2 to the left direction
			transform.eulerAngles =  new Vector3(0,0,180); // Changing the angle of our player to be facing left
		}
		if (Input.GetKey (KeyCode.RightArrow)) { // checking to see if the right arrow key has been pressed
			PlayerInput += new Vector2(1,0); // setting the player input vector 2 to the right direction
			transform.eulerAngles = new Vector3 (0,0,0); // Changing the angle of our player to be facing right
		}

	}

	 


}
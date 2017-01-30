using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
	public float playerspeed; //creating a variable that will function as the speed our player will move at
	bool Able_To_Move = true; // Creating a boolean Variable to check if the player is able to move or not, use for later camera movement and pausing our character

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Able_To_Move == true) { // checking to see if the player is able to move
		ArrowKeyMovement(); // implementing our player movement function
		}
	}

	void ArrowKeyMovement () { //creating a void to register commands to the arrow keys
	if (Input.GetKey (KeyCode.UpArrow)) { // checking to see if the up arrow key has been pressed
		transform.position += new Vector3 (0,playerspeed,0); // adding the player speed variable to the y position of our player in the positive direction
		transform.eulerAngles = new Vector3 (0,0,0); // changing the rotation of our player to match the upward direction of movement
	}
	if (Input.GetKey (KeyCode.DownArrow)) { // checking to see if the down arrow key has been pressed
		transform.position += new Vector3 (0,-playerspeed,0); // adding the player speed variable to the y position of our player in the negative direction
		transform.eulerAngles = new Vector3 (0,0,180); // changing the rotation of our player to match the downward direction of movement

	}
	if (Input.GetKey (KeyCode.LeftArrow)) { // checking to see if the left arrow key has been pressed
			transform.position += new Vector3 (-playerspeed,0,0); // adding the player speed variable to the x position of our player in the negative direction
			transform.eulerAngles = new Vector3 (0,0,90); // changing the rotation of our player to match the left direction of movement

	}
	if (Input.GetKey (KeyCode.RightArrow)) { // checking to see if the right arrow key has been pressed
			transform.position += new Vector3 (playerspeed,0,0); // adding the player speed variable to the x position of our player in the positive direction
			transform.eulerAngles = new Vector3 (0,0,-90); // changing the rotation of our player to match the right direction of movement

	}

	}


}
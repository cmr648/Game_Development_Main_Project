using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
	public float playerspeed; //creating a variable that will function as the speed our player will move at

	Rigidbody2D rb; // creating a rb variable to get the players rigidbody2d

	Vector2 PlayerInput; // Creating a vector2 to adjust on player input
	Vector2 currentPlayerPos; //Creating a vector 2 for the current player position

	public GameObject Pause_Panel; // creating a public gameobject for our pause panel
	bool isPaused; // creating a boolean to check to see if the game is paused or not

	public static float Player_Bullet_Spawn_Position; // creating a public statci float reference to our player spawn position

	public Sprite Down_Sprite; // creating a public sprite reference to our down sprite
	public Sprite Up_Sprite; // creating a public sprite reference to our up sprite
	public Sprite Left_Sprite; // creating a public sprite reference to our left sprite
	public Sprite Right_Sprite; // creating a public sprite reference to our right sprite

	SpriteRenderer Player_Renderer; // creating a reference to our player sprite renderer

	CircleCollider2D Player_Collider; // making a public object to later reference the players circle collider 2d

	AudioSource Background_Music_For_Pause; // creating a background music source for pausing

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>(); // setting our rb variable to the current rigidbody of the player
		isPaused = false; // setting our is paused boolean to be false
		Pause_Panel.SetActive(false); // turning our pause menu off at the start of the game

		Player_Renderer = GetComponent<SpriteRenderer>(); // assigning the players sprite renderer to our player renderer reference
		Player_Collider = GetComponent<CircleCollider2D>(); // assigning the players circle collider 2d to the player collider reference

		Background_Music_For_Pause = GameObject.FindGameObjectWithTag("Background_Music").GetComponent<AudioSource>(); // assining our background music for pause gameobject to the current background music

		}
	
	// Update is called once per frame
	void Update ()
	{
		ArrowKeyMovement(); // implementing our player movement function
		PlayerAngleMovement(); // implementing our player angle movement
		PlayerPause(); // implementing our player pause script
	}

	void FixedUpdate(){ // an update function that runs on a time stamp rather than every rendered frame
		currentPlayerPos = new Vector2(transform.position.x,transform.position.y); // resetting the current player position on fixed update
		rb.MovePosition(currentPlayerPos + PlayerInput*playerspeed); //moving the position of the player every time
	}

	void ArrowKeyMovement ()
	{ //creating a void to register commands to the arrow keys
		PlayerInput = Vector2.zero;
		if (Input.GetKey (KeyCode.UpArrow)) { // checking to see if the up arrow key has been pressed
			PlayerInput += new Vector2 (0, 1); // setting the player input vector 2 to the up direction
		} 
		if (Input.GetKey (KeyCode.DownArrow)) { // checking to see if the down arrow key has been pressed
			PlayerInput += new Vector2 (0, -1); // setting the player input vector 2 to the down direction
		} 
		if (Input.GetKey (KeyCode.LeftArrow)) { // checking to see if the left arrow key has been pressed
			PlayerInput += new Vector2 (-1, 0); // setting the player input vector 2 to the left direction
		} 
		if (Input.GetKey (KeyCode.RightArrow)) { // checking to see if the right arrow key has been pressed
			PlayerInput += new Vector2 (1, 0); // setting the player input vector 2 to the right direction
		} 
	}

	void PlayerAngleMovement(){
		if (Input.GetKey (KeyCode.W)) { // checking to see if the W key has been pressed
		//	transform.eulerAngles = new Vector3 (0,0,90); // Changing the angle of our player to be facing up 
			Player_Renderer.sprite = Up_Sprite; // assinging the up sprite to our player
			Player_Bullet_Spawn_Position = 1; // setting our player bullet spawn position to be equal to 1
			Player_Collider.offset = new Vector2(0,0); // setting the player collider ofsett to be centered
 		


		} 

		if (Input.GetKey (KeyCode.S)) { // checking to see if the S key has been pressed
		//	transform.eulerAngles = new Vector3 (0,0,-90); // Changing the angle of our player to be facing up 
			Player_Renderer.sprite = Down_Sprite; // assigning the down sprite to our player
			Player_Bullet_Spawn_Position = 3; // setting our player bullet spawn position to be equal to 3
			Player_Collider.offset = new Vector2(0,0); // setting the player colllider offset to be centered


 			} 

		if (Input.GetKey (KeyCode.A)) { // checking to see if the A key has been pressed
			//transform.eulerAngles = new Vector3 (0,0,180); // Changing the angle of our player to be facing up 
			Player_Renderer.sprite = Left_Sprite; // assigning the left sprite to our player
			Player_Bullet_Spawn_Position = 4; // setting our player bullet spawn position to be equal to 4
			Player_Collider.offset = new Vector2(.11f,0); // setting the player collider to have a left offsett

		} 

		if (Input.GetKey (KeyCode.D)) { // checking to see if the D key has been pressed
			//transform.eulerAngles = new Vector3 (0,0,0); // Changing the angle of our player to be facing up 
			Player_Renderer.sprite = Right_Sprite; // assigning the right sprite to our player
			Player_Bullet_Spawn_Position = 2; // setting our player bullet spawn position to be equal to 2
			Player_Collider.offset = new Vector2(-.11f,0); // setting the player collider to have a right offsett

		} 
	}

	void PlayerPause ()
	{ // setting up our player pause command

		Pause_Panel.SetActive (isPaused); //setting our pause panel to be active on the toggle of if the game is pasued

		if (Input.GetKeyDown (KeyCode.Escape)) { // checking to see if the escape key has been presed
			isPaused = !isPaused; // toggleing our is paused bollean to be on/off
		}

		if (isPaused) { // checking to see if the game is paused
			Time.timeScale = 0; // pausing the game by freezning time
			Background_Music_For_Pause.Pause(); // pausing our background music
		}

		if (!isPaused) { // checking to see if the game is not paused
			Time.timeScale = 1; // setting our time to the normal speed
			if (Background_Music_For_Pause.isPlaying == false) { // checking to see if our background music is not currently playing playing
				Background_Music_For_Pause.Play(); // turning the music back on
			}

		}

	}

}
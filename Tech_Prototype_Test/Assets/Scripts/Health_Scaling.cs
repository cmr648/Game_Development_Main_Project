﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; // using a ui componemt

public class Health_Scaling : MonoBehaviour {

	public GameObject Health_Bar; // creating a public gameobject for the healthbar 
	public float Player_Total_Health; // creating a public float to calcualte and change the total player health
	public float Player_Current_Health; // creating a public float to calcualte and change the total player health
	public float Player_Health_Boost; // creating a public float to calculate the health boost that will be added to the player health
	public float Player_Damage; // creating a public variable for player damage that the player will take;

	public Animator Heart_Anim; // creatinga an animator for our heart beat UI element

	public GameObject sound_Manager; // creatinig a public gameobject reference for our sound manager
	public AudioClip Health_Up; // creating a public audio clip for health going up
	public AudioClip Death_Audio; // creatina  public audio clip to play when we die
	public AudioClip Player_Damage_Audio; // creating a public audio clip reference for when the player takes damage

	public Image Fader; // creating a public image reference for our fader
	public Animator Fader_Animator; // creating a public animator reference for our fader

	SpriteRenderer Player_Renderer; // creating a reference to our player renderer

	GameObject Background_Music; // Creating a gameobject reference to background music

	Sprite Character_Death_Sprite; // creating a public sprite reference for our character
	public Sprite Character_Death_Player_1;
	public Sprite Character_Death_Player_2;
	public Sprite Character_Death_Player_3;
	public Sprite Character_Death_Player_4;
	public Sprite Character_Death_Player_5;

	bool Can_Be_Damaged; // Creating a bollean to see if the player can be damaged or not
	float Player_Damage_Keeper; // Creating a float to keep the player damage variable

	public float Camera_Shake_Magnitude;
	public float Camera_Shake_Duration;

	public GameObject Red_Flash;
	public GameObject Green_Flash;
	public float Red_Flash_Wait_Seconds;

	// Use this for initialization
	void Start () {
		Red_Flash.SetActive(false);
		Green_Flash.SetActive(false);

		Choose_Character_Death();
		Player_Current_Health = Player_Total_Health; // setting the players current health to be equal to the players current health at the start of the game
		Player_Renderer = GetComponent<SpriteRenderer>(); // assigning the players sprite renderer to player renderer
		Background_Music = GameObject.FindGameObjectWithTag("Background_Music"); // finding the background music gameobject

		Can_Be_Damaged = true; // making the player able to be damaged at the start of the game
		Player_Damage_Keeper = Player_Damage; // setting our player damage keeper to be the current player damage
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate ()
	{ // an update function taht is called every frame instead of every rendered frame
		Health_Bar.transform.localScale = new Vector3 ((Player_Current_Health / Player_Total_Health), 1, 1); // changing the scale of the health bar to change when taking damage
		Damage_Bounds (); // implementing our damage bounds function
		Game_Over_Check (); // implementing game over check
		Animation_Speed (); // implementing our animation speed function

		if (Fader_Animator.GetBool ("Fade") == true) { // checking to see if our fader animator fade boolean variable is equal to true
		Check_For_Black(); // then employing our check for black function
		}

	}

	void OnCollisionEnter2D (Collision2D col)
	{ //checking to see if the player is colliding with an object

		if (col.gameObject.tag == "Enemy") { // checking to see if the player is colliding with an enemy game object
			Player_Current_Health -= Player_Damage; // subtracting the player damage from the health bar
			StartCoroutine("Color_Change_Damage"); // begining our color change damage IENuemerator
			Camera.main.GetComponent<Screen_Shake>().Set_Screen_Shake(Camera_Shake_Magnitude,Camera_Shake_Duration);
			StartCoroutine("Flash_Red");

		}

		if (col.gameObject.tag == "Skeleton") { // checking to see if the player is colliding with a skeleton game object
			Player_Current_Health -= Player_Damage; // subtracting the player damage from the health bar
			StartCoroutine("Color_Change_Damage"); // begining our color change damage IENuemerator
			Camera.main.GetComponent<Screen_Shake>().Set_Screen_Shake(Camera_Shake_Magnitude,Camera_Shake_Duration);
			StartCoroutine("Flash_Red");
		}

		if (col.gameObject.tag == "Enemy_Bullet") { // checking to see if the player is colliding with an enemy bullet game object
			Player_Current_Health -= Player_Damage; // subtracting the player damage from the health bar
			StartCoroutine("Color_Change_Damage"); // begining our color change damage IENuemerator
			Destroy(col.gameObject); // destroy the bullet
			Camera.main.GetComponent<Screen_Shake>().Set_Screen_Shake(Camera_Shake_Magnitude,Camera_Shake_Duration);
			StartCoroutine("Flash_Red");
		};

		if (col.gameObject.tag == "Health_Boost") { // checking to see if the player is colliding with a health boost game object
			Player_Current_Health += Player_Health_Boost; // adding the player health boost to the health bar
			StartCoroutine("Color_Change_Health"); // begining our color change health IEnumerator
			Destroy(col.gameObject); // get rid of the health pack upon using it one time
			sound_Manager.GetComponent<Sound>().Playsound(Health_Up,1); // playing our health up sound
			StartCoroutine("Flash_Green");
		}

	}

	void Damage_Bounds ()
	{ //creating our damage bounds function
		if (Player_Current_Health <= 0) { // checking to see if the player health is less than or equal to 0;
			Player_Current_Health = 0; // resetting the player health to be 0 so the health bar wont go backwards
		}

		if (Player_Current_Health >= Player_Total_Health) { // checking to see if the player health is greater than or equal to the player total health
			Player_Current_Health = Player_Total_Health; // resetting the player health to be 0 so the health bar wont go to far
		}
		
	}

	void Game_Over_Check ()
	{ // creating our game over check function
		if (Player_Current_Health == 0) { // checking to see if player health = 0


			if (PlayerPrefs.GetFloat ("Highscore") < Treasure_Pickup.Player_Score) { // checking to see if our current highscore is less than the player score
				PlayerPrefs.SetFloat ("Highscore", Treasure_Pickup.Player_Score); // setting the high score to our player score at the moment of death
				PlayerPrefs.SetString ("HighscoreTime", PlayerPrefs.GetString ("PlayerTime")); // setting our high score time to our current player time
			}

			if (PlayerPrefs.GetFloat ("Highscore2") < Treasure_Pickup.Player_Score && Treasure_Pickup.Player_Score < PlayerPrefs.GetFloat ("Highscore")) { // checking to see if our high score 2 is less than the player score and the current highest score and is greater than the 3rd highest score
				PlayerPrefs.SetFloat ("Highscore2", Treasure_Pickup.Player_Score); // setting the high score 2 variable to our player score at the moment of death
				PlayerPrefs.SetString ("Highscore2Time", PlayerPrefs.GetString ("PlayerTime"));  // setting our high score 2 time to our current player time
			}

			if (PlayerPrefs.GetFloat ("Highscore3") < Treasure_Pickup.Player_Score && Treasure_Pickup.Player_Score < PlayerPrefs.GetFloat ("Highscore2")) { // checking to see if the high score 3 is less than player score and player score is less than high score 2
				PlayerPrefs.SetFloat ("Highscore3", Treasure_Pickup.Player_Score); //  setting our high score 3 variable to our current player score
				PlayerPrefs.SetString ("Highscore3Time", PlayerPrefs.GetString ("PlayerTime"));  // setting our high score 3 time to our current player time
			}

			Player_Renderer.color = Color.red; // changing the player color to red
			GetComponent<Player_Movement> ().enabled = false; // turning off player movement
			GetComponent<Player_Shooting> ().enabled = false; // turning off player shooting
			GetComponent<Hands> ().enabled = false; // turning off the hands script
			GetComponent<SpriteRenderer> ().sprite = Character_Death_Sprite; // setting our character death to be our death sprite
			Destroy (GetComponent<Rigidbody2D> ()); // destroying our rigidbody2d

			Fader_Animator.SetBool ("Fade", true); // setting our fade boolean to true to make the animator fader fade out

		

			//Sound.Main_Sound.Playsound(Death_Audio,1);

			Destroy (Background_Music); // Destroying our background music gameobject
			sound_Manager.GetComponent<Sound> ().Playsound (Death_Audio, 1); // playing our death audio sound


		//	SceneManager.LoadScene("Game_Over"); // loading our game over screen if the player health = 0
		}

	}

	void Animation_Speed ()
	{ // creating a void to change the speed of our heart beat
		if (Player_Current_Health > Player_Total_Health / 2) { // checking to see if the player has over 50% health
			Heart_Anim.speed = 1; // setting the heart anim speed to be normal
		} 
		else { // if the player has below 50% health
			Heart_Anim.speed = 2; // setting the heart anim speed to be faster
		}

	

	}

	void Check_For_Black (){ // creating another check for black void just like in load level
		if (Fader.GetComponent<Image> ().color.a == 1 && Player_Current_Health == 0) {  // checking to see if our faders colors alpha value is equal to 1 and the player current health is nothing
			SceneManager.LoadScene("Game_Over");  // loading a new scene in which we enter the scene publicly
		}
	}

	IEnumerator Color_Change_Damage ()
	{ // creating a color change sequence 
//	sound_Manager.GetComponent<Sound>().Playsound(Player_Damage_Audio,1); // playing the player damage audio sound
//	Player_Renderer.color = Color.red; // changing the color to red
//	yield return new WaitForSeconds (.1f); // waiting one second
//	Player_Renderer.color = Color.white; // changing the color back to normal

		if (Can_Be_Damaged == true) { // checking to see if the player is at a state to be damaged
			Can_Be_Damaged = false; // immidiatly setting them to not be able to be damaged
			Player_Damage = 0; /// setting our player damage to 0 to allow are player not to be damaged
			sound_Manager.GetComponent<Sound>().Playsound(Player_Damage_Audio,1); // playing our player damage sound
			Player_Renderer.color = Color.red; // changing the player to be a red color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Renderer.color = Color.white; // changing the player back to its normal color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Renderer.color = Color.red; // changing the player to be a red color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Renderer.color = Color.white; // changing the player back to its normal color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Renderer.color = Color.red; // changing the player to be a red color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Renderer.color = Color.white; // changing the player back to its normal color
			yield return new WaitForSeconds(.1f); // having it wait 2 seconds
			Player_Damage = Player_Damage_Keeper; // resetting our player damage back to norma 
			Can_Be_Damaged = true; // setting the player to be able to be damaged again
		}

	}

	IEnumerator Color_Change_Health(){ // creating a color change sequence 
	Player_Renderer.color = Color.green; // changing the color to red
	yield return new WaitForSeconds (.1f); // waiting one second
	Player_Renderer.color = Color.white; // changing the color back to normal
	}

	void Choose_Character_Death ()
	{
		if (PlayerPrefs.GetFloat ("Character_Selection") == 0) {
			Character_Death_Sprite = Character_Death_Player_1;

		}

		if (PlayerPrefs.GetFloat ("Character_Selection") == 1) {
			Character_Death_Sprite = Character_Death_Player_2;

		}

		if (PlayerPrefs.GetFloat ("Character_Selection") == 2) {
			Character_Death_Sprite = Character_Death_Player_3;

		}

		if (PlayerPrefs.GetFloat ("Character_Selection") == 3) {
			Character_Death_Sprite = Character_Death_Player_4;

		}

		if (PlayerPrefs.GetFloat ("Character_Selection") == 4) {
			Character_Death_Sprite = Character_Death_Player_5;

		}
	}

	IEnumerator Flash_Red ()
	{
		Red_Flash.SetActive(true);
		yield return new WaitForSeconds(Red_Flash_Wait_Seconds);
		Red_Flash.SetActive(false);

	}

	IEnumerator Flash_Green ()
	{
		Green_Flash.SetActive(true);
		yield return new WaitForSeconds(Red_Flash_Wait_Seconds);
		Green_Flash.SetActive(false);

	}

}

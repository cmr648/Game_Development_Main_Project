using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

	public GameObject Bullet; // Creating a public game object to add our bullet prefab
	GameObject Bullet_Spawn_Position; // Creating a public game object to set our bullet spawn position to
	public float Bullet_Time; // Cretaing a delay that the bullets will be fired upon
	SpriteRenderer bullet_renderer; // creating a bulletrenderer to take the sprite renderer of the bullet and edit it

	Vector3 bulletNormalSize = new Vector3 (1.9f,1.9f,1.9f); // creating a vector3 for the bullet normal size
	Vector3 bulletHalfSize = new Vector3(1.4f,1.4f,1.4f); // creating a vector3 for bullet half size
	Vector3 bulletDoubleSize = new Vector3(2.3f,2.3f,2.3f); // creating a vector3 for bullet double size
	public float bulletSlow; // creating a float for our bullet on the slow powerup
	public float bulletFast; // creating a float for our bullet on the slow powerup
	public float Bullet_Normal_Speed; // creating a float for our normal bullet speed

	public Sprite Large_Boomerang; // creating a public sprite for our large boomerang
	public Sprite Normal_Boomerang; // creating a public sprite for our normal boomerang
	public Sprite Small_Boomerang; // creating a public sprite for our small boomerang

	public static float Bullet_Limit;  // Creating a public static float of bullet limit to edit on screen at one time
	public float Bullet_Amount; // Creating float for bullet amount that can be fired at once

	public AudioClip[] Boomerang_Swoosh; // creatinga  public audio clip array for the boomerang swish sounds
	public AudioClip Boomerang_Switch; // creating a public audio clip for switching boomerangs
	public GameObject sound_Manager; // creatinig a public gameobject reference for our sound manager

	public GameObject Up_Bullet_Spawn_Position; // creating a public gameobject reference to our up bullet spawn position
	public GameObject Down_Bullet_Spawn_Position; // creating a public gameobject reference to our down bullet spawn position
	public GameObject Left_Bullet_Spawn_Position; // creating a public gameobject reference to our left bullet spawn position
	public GameObject Right_Bullet_Spawn_Position; // creating a public gameobject reference to our right bullet spawn position


	void Awake(){ // creating a function from the start of the machine bieng awake even be for start
		Bullet.transform.localScale = bulletNormalSize; // setting the bullet transform local scale to be bullet normal size

	}

	// Use this for initialization
	void Start () {

		bullet_renderer = Bullet.GetComponentInChildren<SpriteRenderer>(); // getting the sprite renderer of our bullet and applying it to the bullet renderer
		bullet_renderer.sprite = Normal_Boomerang; // setting our bullet rendeer sprite to be the normal boomerang at the start of the game

		bullet_renderer.color = Color.white; // setting the bullet to be white at the start of the game
		Bullet.transform.localScale =  bulletNormalSize; // setting the bullet to be normal size at the start of the game
		Bullet_Movement.Move_Speed = Bullet_Normal_Speed; // changing the bullet speed to be back to normal


		Bullet_Limit = 0; // setting our bullet limit





		}
	
	// Update is called once per frame
	void Update ()
	{
			//Pick_Bullet_Spawn_Position(); // setting up pick bullet spawn position

			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.A)) { // an if statement that checks to see if the WSAD keys have been pressed
				InvokeRepeating ("Fire_Bullet", 0, Bullet_Time); // repeating our fire bullet function to make the player fire on a delay

			}

			if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) { // if our keys are not bieng pressed it will cancel the invoke
				CancelInvoke (); // cancel the invoke repeating method
			}

	}

	void FixedUpdate(){
		//Pick_Bullet_Spawn_Position();
	}

	void Fire_Bullet ()
	{ // creating our fire bullet function
//		if (Bullet_Limit < Bullet_Amount) { // checking to see if our bullet limit is less than 3
//			Instantiate (Bullet, Bullet_Spawn_Position.transform.position, Bullet_Spawn_Position.transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed
//			Bullet_Limit = Bullet_Limit +1; // adding 1 to our bullet limit
//
//			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Swoosh[Random.Range(0,Boomerang_Swoosh.Length)],1); // playing a random 1 of 3 boomerang sounds

		if (Player_Movement.Player_Bullet_Spawn_Position == 1 && Bullet_Limit < Bullet_Amount) { // checking to see if player bullet spawn position = 1
			Instantiate (Bullet, Up_Bullet_Spawn_Position.transform.position, Up_Bullet_Spawn_Position.transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed
			Bullet_Limit = Bullet_Limit +1; // adding 1 to our bullet limit
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Swoosh[Random.Range(0,Boomerang_Swoosh.Length)],1); // playing a random 1 of 3 boomerang sounds
		}

		if (Player_Movement.Player_Bullet_Spawn_Position == 2 && Bullet_Limit < Bullet_Amount) { // checking to see if player bullet spawn position = 1
			Instantiate (Bullet, Right_Bullet_Spawn_Position.transform.position, Right_Bullet_Spawn_Position.transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed
			Bullet_Limit = Bullet_Limit +1; // adding 1 to our bullet limit
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Swoosh[Random.Range(0,Boomerang_Swoosh.Length)],1); // playing a random 1 of 3 boomerang sounds
		}

		if (Player_Movement.Player_Bullet_Spawn_Position == 3 && Bullet_Limit < Bullet_Amount) { // checking to see if player bullet spawn position = 1
			Instantiate (Bullet, Down_Bullet_Spawn_Position.transform.position, Down_Bullet_Spawn_Position.transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed
			Bullet_Limit = Bullet_Limit +1; // adding 1 to our bullet limit
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Swoosh[Random.Range(0,Boomerang_Swoosh.Length)],1); // playing a random 1 of 3 boomerang sounds
		}
		if (Player_Movement.Player_Bullet_Spawn_Position == 4 && Bullet_Limit < Bullet_Amount) { // checking to see if player bullet spawn position = 1
			Instantiate (Bullet, Left_Bullet_Spawn_Position.transform.position, Left_Bullet_Spawn_Position.transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed
			Bullet_Limit = Bullet_Limit +1; // adding 1 to our bullet limit
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Swoosh[Random.Range(0,Boomerang_Swoosh.Length)],1); // playing a random 1 of 3 boomerang sounds
		}


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
			Destroy (col.gameObject); // remove the pickup
			Bullet.transform.localScale = bulletDoubleSize; // changing the size of the bullet to be twice as large
			Bullet_Movement.Move_Speed = bulletSlow; // changing the speed of the bullet to be half speed
			bullet_renderer.sprite = Large_Boomerang; // changing the bullet sprite to a large boomerang
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Switch,1); // playing our boomerang switch sound
		}

		if (col.gameObject.tag == "BulletSizeDown") { // if the player has collided with an arrow pickup 
			Destroy (col.gameObject); // remove the pickup
			Bullet.transform.localScale = bulletHalfSize;  // changing the size of the bullet to be half
			Bullet_Movement.Move_Speed = bulletFast; // changing the speed of the bullet to be *2
			bullet_renderer.sprite = Small_Boomerang; // changing the bullet sprite to a small boomerang
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Switch,1); // playing our boomerang switch sound
		}

		if (col.gameObject.tag == "BulletSizeNormal") { // if the player has collided with the normal size arrow pickup
			Destroy(col.gameObject); // remove the pickup
			Bullet.transform.localScale = bulletNormalSize; // changing the size of the bullet to be back to normal
			Bullet_Movement.Move_Speed = Bullet_Normal_Speed; // changing the bullet speed to be back to normal
			bullet_renderer.sprite = Normal_Boomerang; // changing the bullet renderers sprite to be back to a normal boomerang
			sound_Manager.GetComponent<Sound>().Playsound(Boomerang_Switch,1); // playing our boomerang switch sound
		}





	}

	void Pick_Bullet_Spawn_Position ()
	{ // creating a function to help pick the bullet spawn position
		if (Player_Movement.Player_Bullet_Spawn_Position == 1) { // checking to see if player bullet spawn position = 1
		Bullet_Spawn_Position = Up_Bullet_Spawn_Position; // changing it to up bullet spawn position
		}

		if (Player_Movement.Player_Bullet_Spawn_Position == 2) { // checking to see if player bullet spawn position = 2
		Bullet_Spawn_Position =  Right_Bullet_Spawn_Position; // changing it to right bullet spawn position
		}

		if (Player_Movement.Player_Bullet_Spawn_Position == 3) { // checking to see if player bullet spawn position = 3
		Bullet_Spawn_Position = Down_Bullet_Spawn_Position; // changing it to down bullet spawn position
		}

		if (Player_Movement.Player_Bullet_Spawn_Position == 4) { // checking to see if player bullet spawn position = 4
		Bullet_Spawn_Position = Left_Bullet_Spawn_Position; // changing it to left bullet spawn position
		}

	}



}

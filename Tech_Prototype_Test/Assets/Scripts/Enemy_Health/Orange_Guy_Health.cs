using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Orange_Guy_Health : MonoBehaviour {

	public float Start_Health; // the health that an enemy will start with
	float Half_Health;
	public GameObject[] Treasure_Drops; // creating a public list of gameobjects for the enemys to drop when they die
	int Treasure_Choose; // creating a treasure chooser variable to choose the treasure that will be droped by an enemy
	public SpriteRenderer Enemy_Renderer; // Creating a variable to get the renderer of the enemy game object
	public SpriteRenderer Top_Teeth_Renderer; // Creating a variable to get the rendeer of the top teeth
	public SpriteRenderer Bottom_Teeth_Renderer; // creating a variable to get the renderer of the botoom teeth
	public ParticleSystem Enemy_Death_Particle; //Creating a public enemy death particle system to instantiate upon death
	public ParticleSystem Enemy_Damage_Particle; // creating a public enemy damage particle system to instantiate upon damage
	public ParticleSystem Enemy_Death_Splat; // Creatinga  public Enemy death splat particle system to instantiate

	GameObject player; // creating a public gameobject reference to the player 

	public float Camera_Shake_Magnitude;
	public float Camera_Shake_Duration;

	// Use this for initialization
	void Start () {
	player = GameObject.FindGameObjectWithTag("Player"); // finding the player gameobject in our scene

	Top_Teeth_Renderer.GetComponent<Animator>().speed = .5f; // setting our top teeth renderer to animate at half speed
	Bottom_Teeth_Renderer.GetComponent<Animator>().speed = .5f; // setting our bottom teeth rendeer to animate at half speed 

	//Enemy_Renderer = GetComponentInChildren<SpriteRenderer>(); // assigning the players sprite renderer to the enemy renderer at the start of the game
	Half_Health = Start_Health/2; // setting half health to be half the player health

	Dungeon_Clear_Checker.Enemy_Amount = Dungeon_Clear_Checker.Enemy_Amount + 1; // adding one to the enemy amount for every enemy on screen
				
	}
	
	// Update is called once per frame
	void Update () {
//		transform.right = Player.transform.position - transform.position;
	}

	void FixedUpdate () // an update function that is called every frame
	{
		// ROTATING CODE
		Vector3 Direction = (player.transform.position - transform.position); //creating a vector 3 to get the direction that the orange enemy should be rotating
		float Direction_Angle = Mathf.Atan2(Direction.y,Direction.x)*Mathf.Rad2Deg; // taking our direction and converting its magnitude and angles from radians to degrees
		transform.rotation = Quaternion.AngleAxis(Direction_Angle,Vector3.forward); // changing the transform.rotation t our new direction in degrees
	

		Treasure_Choose = Random.Range(0,Treasure_Drops.Length); // setting our treasure choose variable to be a different treasure every time an enemy dies

		if (Start_Health <= Half_Health) { // checking to see if the enemy health is less than or equal to 2
			Enemy_Renderer.color = Color.red; // assinging the red color to the enemy
			Top_Teeth_Renderer.color = Color.red; // assinging the color red to the enemy top teeth
			Bottom_Teeth_Renderer.color = Color.red; // Assigning the color red to the enemy bottom teeth

		}

		if (Start_Health <= 0) { // checking to see if the enemy has no life left
		Camera.main.GetComponent<Screen_Shake>().Set_Screen_Shake(Camera_Shake_Magnitude,Camera_Shake_Duration);


		Destroy(gameObject); // destroy the enemy game object
		Instantiate(Enemy_Death_Particle,transform.position,Quaternion.identity); // instantiating the enemy death particle system upon enemy death
		Instantiate(Enemy_Death_Splat,transform.position,Quaternion.identity); // instantiating the enemy death splat particle system upon enemy death
		Dungeon_Clear_Checker.Enemy_Amount = Dungeon_Clear_Checker.Enemy_Amount -1; // subtracting the enemy from the enemy amount variable
		Instantiate(Treasure_Drops[Treasure_Choose],transform.position,Quaternion.identity); // dropping the treasure in the place of the enemy when they die
		}


	}

	void OnCollisionEnter2D (Collision2D col)	{ // a void that checks to see if the enemy collided with soething
		if (col.gameObject.tag == "Player_Bullet") { // checking to see if the collision was with a player bullet
			Start_Health -= 1; // make the enemy lose health
			Bullet_Movement.Move_Speed = -Bullet_Movement.Move_Speed; // reversing the boomerang speed
			Instantiate(Enemy_Damage_Particle,transform.position,Quaternion.identity); // instantiating the enemy damage particle system upon damage
			//	Destroy(col.gameObject); // destroy the boomerang

			Camera.main.GetComponent<Screen_Shake>().Set_Screen_Shake(Camera_Shake_Magnitude/2,Camera_Shake_Duration/2);


		}


	}
}

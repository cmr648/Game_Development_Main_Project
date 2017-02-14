using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

	public GameObject Bullet; // Creating a public game object to add our bullet prefab
	public GameObject Bullet_Spawn_Position; // Creating a public game object to set our bullet spawn position to
	public float Bullet_Time; // Cretaing a delay that the bullets will be fired upon
	Vector3 bulletSpawnPositionEdit;

	// Use this for initialization
	void Start () {
		bulletSpawnPositionEdit = new Vector3 (Bullet_Spawn_Position.transform.position.x, Bullet_Spawn_Position.transform.position.y, Bullet_Spawn_Position.transform.position.z+10); // setting the bullet spawn position every time a bullet is instantiated
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.A)) { // an if statement that checks to see if the WSAD keys have been pressed

			InvokeRepeating ("Fire_Bullet", 0, Bullet_Time); // repeating our fire bullet function to make the player fire on a delay

		}

		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)){ // if our keys are not bieng pressed it will cancel the invoke
			CancelInvoke(); // cancel the invoke repeating method
		}
	}

	void Fire_Bullet(){ // creating our fire bullet function
		Instantiate(Bullet, Bullet_Spawn_Position.transform.position, transform.rotation); // instantiating the bullet prefab when the WSAD keys are pressed

	}

}

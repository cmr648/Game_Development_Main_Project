﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour {

	public GameObject Bullet; // Creating a public game object to add our bullet prefab
	public GameObject Bullet_Spawn_Position; // Creating a public game object to set our bullet spawn position to
	Vector3 bulletSpawnPositionEdit;

	// Use this for initialization
	void Start () {
		bulletSpawnPositionEdit = new Vector3 (Bullet_Spawn_Position.transform.position.x, Bullet_Spawn_Position.transform.position.y, Bullet_Spawn_Position.transform.position.z+10); // setting the bullet spawn position every time a bullet is instantiated
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){ // an if statement that checks to see if the spacebar has been pressed

			Instantiate(Bullet, Bullet_Spawn_Position.transform.position, transform.rotation); // instantiating the bullet prefab when the spacebar is pressed

		}
	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enable : MonoBehaviour {

public Collider2D Spawn_Collider; // Creating a public collider to assign our spawn collider too

	// Use this for initialization
	void Start () {
		Spawn_Collider.enabled = false; // starting our collider as disabled to allow th eplayer object to pass through it
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){ // a void that checks to see if the player has entered a trigger

	if(col.gameObject.tag == "Player"){ // checking to see if the object that the spawn collider is colliding with is the player
	Spawn_Collider.enabled = true; // enabling the spawn gameobject to allow the player to spawn a new room
	}

	}

	void OnTriggerExit2D (Collider2D col) // A void that checks to see if the player has exited a trigger
	{
	if(col.gameObject.tag == "Player"){ // checking to see if the object that the spawn collider is colliding with is the player
		Destroy(gameObject); // getting rid of the gameobject once the player has passed through it
	}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Room_Enable : MonoBehaviour {


	void Awake(){
		//GetComponent<Random_Room>().enabled = false; // starting with the ranom room script bieng false
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D (Collider2D col) 
	{

		if (col.gameObject.tag == "Player") { // checking to see if the player is in the room 
		GetComponent<Random_Room>().enabled = false; // making the random room script not enabled
		} 

	}

	void OnTriggerExit2D (Collider2D col) // checking to see if the player has exited a room 
	{

		if (col.gameObject.tag == "Player") { // if the gameobject is the player
		GetComponent<Random_Room>().enabled = true; // reenable the random room script
		} 

	}
}

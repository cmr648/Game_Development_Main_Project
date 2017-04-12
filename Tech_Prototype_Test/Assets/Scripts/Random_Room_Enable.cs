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

	void OnTriggerEnter2D (Collider2D col)  // A function that checks to see if an object is currently in this gamobjects trigger
	{

		if (col.gameObject.tag == "Player") { // checking to see if the object colliding with the trigger is the player
		GetComponent<Random_Room>().enabled = false; // making the random room script not enabled
		} 

	}

	void OnTriggerExit2D (Collider2D col) // A function that checks to see if an object is currently out of this gamobjects trigger
	{

		if (col.gameObject.tag == "Player") { // checking to see if the object colliding with the trigger is the player
		GetComponent<Random_Room>().enabled = true; // making the random room script enabled
		} 

	}
}

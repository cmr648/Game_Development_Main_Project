using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Door_UI : MonoBehaviour {

	int Door_Chance; // Creatinga  float for door chance

	// Use this for initialization
	void Start ()
	{
		Door_Chance = Random.Range (0, 9); //  creating  a random range and assinging it to door chance

		if (Door_Chance == 1) { // checking to see if our door chance equals one
			gameObject.SetActive (true); //setting the gameobject to be on
		} else {
			gameObject.SetActive(false); // setting our gameobject to be off
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

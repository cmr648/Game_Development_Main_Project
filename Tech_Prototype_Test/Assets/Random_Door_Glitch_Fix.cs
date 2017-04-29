using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Door_Glitch_Fix : MonoBehaviour {

	public GameObject Partner_Door; // creating a public gameobject referecne for our other door

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Partner_Door.activeInHierarchy) { // checking to see if the partner door is active
			gameObject.SetActive(false); // setting our door to be inactive now

		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Door : MonoBehaviour {

	SpriteRenderer Door_Renderer; // creating a sprite renderer variable to be able to take the sprite renderer from our door
	BoxCollider2D Door_Collider; // Creating a box collider variale to be able to take the box collider from our door
	int Door_Chooser; // Creating a door chooser int to be able to decide if our door is open or closed

	// Use this for initialization
	void Start ()
	{
		Door_Renderer = GetComponent<SpriteRenderer> (); // taking the sprite renderer from our gameobjcet
		Door_Collider = GetComponent<BoxCollider2D> (); // taking the box collider from our gameobject
		Door_Chooser = Random.Range (0, 6); // assining our door chooser variable to be 50/50
		if (Door_Chooser == 1) { // if the door chooser variable lands on 0
			Door_Renderer.enabled = true; // turning the sprite renderer on
			Door_Collider.enabled = true; // turning the box collider on
		} else {
			Door_Renderer.enabled = false; // turning the sprite renderer off
			Door_Collider.enabled = false; // turning the box collider off
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

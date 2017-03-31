using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Loop_Multiple_Scenes : MonoBehaviour {

	GameObject[] Sound_Loop_List; // creating an array of gameobjects to check for sound looping lists

	void Awake ()
	{ // a start function that happens before start
		Sound_Loop_List = GameObject.FindGameObjectsWithTag ("Background_Music"); // finding all gameobjects with background music variable

		if (Sound_Loop_List.Length > 1) { // checking to see if there is more than one sound loop game objects
			Destroy (this.gameObject); // Having the gameobject destroy itsel
			}
			DontDestroyOnLoad(this.gameObject); // the gameobject should not destroy itself unlsess prompted making it play through multiple scenes
		}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

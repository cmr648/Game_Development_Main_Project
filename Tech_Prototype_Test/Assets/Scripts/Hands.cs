using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour {

	public GameObject Left_Hand; // creating a public gameobject reference to our Left hand
	public GameObject Right_Hand; // creating a public gameobject reference to our Right hand
	public GameObject Up_Hand; // creating a public gameobject reference to our Up hand
	public GameObject Down_Hand; // creating a public gameobject reference to our left hand

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		HandShowing(); // implementing our hand showing void
		
	}

	void HandShowing(){ // creating a seperate void for our hand showing
		if (Input.GetKey (KeyCode.W)) { // checking to see if W has been pressed;
			Up_Hand.SetActive (true);  // setting the up hand to be active
		} else {
			Up_Hand.SetActive(false); // setting the up hand to be inactive
		}

		if (Input.GetKey (KeyCode.S)) { // checking to see if S has been pressed;
			Down_Hand.SetActive (true);  // setting the Down hand to be active
		} else {
			Down_Hand.SetActive(false); // setting the Down hand to be inactive
		}

		if (Input.GetKey (KeyCode.A)) { // checking to see if A has been pressed;
			Left_Hand.SetActive (true);  // setting the Left hand to be active
		} else {
			Left_Hand.SetActive(false); // setting the Left hand to be inactive
		}

		if (Input.GetKey (KeyCode.D)) { // checking to see if D has been pressed;
			Right_Hand.SetActive (true);  // setting the Right hand to be active
		} else {
			Right_Hand.SetActive(false); // setting the Right hand to be inactive
		}
	}


}

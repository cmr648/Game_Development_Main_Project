using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // using the ui editor in unity
using System; // using the system component 

public class Timer : MonoBehaviour {
	// creating float for time unit
	public static float Milliseconds; // creating our milliseconds float
	public static float Seconds; // creating our seconds float
	public static float Minutes; //creating our minutes float 
	public static float Hours; // creating our hours float
	Text GameobjectText; // creating a text component for our gameobject
	string displayTime; // creating a string that will be used to display our time


	// Use this for initialization
	void Start () {
	GameobjectText = GetComponent<Text>(); // getting the text component from our gameobject and assinging it to the text

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate ()
	{ // an update function that runs every frame instead of every rendered frame
		// setting our time units
		Milliseconds += Time.deltaTime * 1000;
		Seconds += Time.deltaTime;

		if (Milliseconds > 1000) { // resetting milliseconds
			Milliseconds = 0;

		}

		if (Seconds >= 60) { // resseting seconds
			Seconds = 0;
			Minutes += 1; // adding one to minutes
		}

		if (Minutes >= 60) { // resetting minutes
			Minutes = 0;
			Hours += 1; //adding one to hours

		}


	displayTime = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",Hours,Minutes,Seconds,Milliseconds); // setting our string to be that of the time since the level has started
	GameobjectText.text = displayTime; //setting the gameobjects text to display the timer
	PlayerPrefs.SetString("PlayerTime",displayTime); // setting a player prefs variable to our timer

	}
}

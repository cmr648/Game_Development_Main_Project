using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Reset_Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Treasure_Pickup.Player_Score = 0; // setting the player_score to 0 at the start of the game
		Timer.Milliseconds = 0; // setting our milliseconds to 0
		Timer.Seconds = 0; // setting our seconds to 0
		Timer.Minutes = 0; // setting our minutes to 0
		Timer.Hours = 0;  // setting our hours to 0
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

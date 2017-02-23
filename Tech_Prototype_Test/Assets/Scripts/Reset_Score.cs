using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Treasure_Pickup.Player_Score = 0; // setting the player_score to 0 at the start of the game
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

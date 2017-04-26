using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_High_Score_Sysetem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset_High_Score(){ // creating a public void to reset the high scores

	//HIGH SCORE NUMBERS
	PlayerPrefs.SetFloat("Highscore",0); // resetting the high score1 system
	PlayerPrefs.SetFloat("Highscore2",0); // resetting the high score2 system
	PlayerPrefs.SetFloat("Highscore3",0); // resetting the high score3 system

	//HIGH SCORE NAMES
	PlayerPrefs.SetString("Highscore_String","???");
	PlayerPrefs.SetString("Highscore_String_2","???");
	PlayerPrefs.SetString("Highscore_String_3","???");

	PlayerPrefs.SetString("HighscoreTime","00:00:00:00");
	PlayerPrefs.SetString("Highscore2Time","00:00:00:00");
	PlayerPrefs.SetString("Highscore3Time","00:00:00:00");
	}
}

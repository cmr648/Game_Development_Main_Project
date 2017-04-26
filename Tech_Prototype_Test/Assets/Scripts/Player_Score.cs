using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // we will be using unity engine.ui for this

public class Player_Score : MonoBehaviour {

	

	public Text playertext; // creating player text to edit
	public Text High_Score_Text; // Creating a high score text to edit
	public Text High_Score_2_Text; // creating a high score 2 text to edit
	public Text High_Score_3_Text; // creating a high score 3 text to edit

	public InputField Enter_Name; // creating a public input field to enter name
	public Text Name_1; // creating a text for name one
	public Text Name_2; // creating a text for name one
	public Text Name_3; // creating a text for name one

	public Text High_Score_Time_Text; // creating a high score time text to edit
	public Text High_Score_2_Time_Text; // creating a high score 2 time text to edit
	public Text High_Score_3_Time_Text; // creating a high score 3 time text to edit

	// Use this for initialization
	void Start () {

	playertext.text = "Your Score: " + PlayerPrefs.GetFloat("CurrentScore"); // assinging the players last score to the player text

	High_Score_Text.text = PlayerPrefs.GetFloat("Highscore").ToString(); //assinging the high score variable to our text

	High_Score_2_Text.text = PlayerPrefs.GetFloat ("Highscore2").ToString(); // assinging the high score 2 variable to our text

	High_Score_3_Text.text = PlayerPrefs.GetFloat ("Highscore3").ToString(); // assinging the high score 3 variable to our text 


	High_Score_Time_Text.text = PlayerPrefs.GetString("HighscoreTime"); // setting our high score time text to be the highest scoring time
	High_Score_2_Time_Text.text = PlayerPrefs.GetString("Highscore2Time"); // setting our high score 2 time text to be the highest scoring time
	High_Score_3_Time_Text.text = PlayerPrefs.GetString("Highscore3Time"); // setting our high score 3 time text to be the highest scoring time

	Enter_Name.gameObject.SetActive(false); // setting the enter name field to be off at the start of the game over scree


	if (Treasure_Pickup.Player_Score  == PlayerPrefs.GetFloat ("Highscore") || Treasure_Pickup.Player_Score  == PlayerPrefs.GetFloat ("Highscore2") || Treasure_Pickup.Player_Score  == PlayerPrefs.GetFloat ("Highscore3")){
		Enter_Name.gameObject.SetActive(true); // setting the neter name field to be off if it matches a high score

	}

	}
	
	// Update is called once per frame
	void Update () {
		Enter_Name.text = Enter_Name.text.ToUpper(); // setting the input field text to be upper case at all times

		Player_Entry();

		Name_1.text = PlayerPrefs.GetString("Highscore_String"); // setting our name1 text to our highest scoring name
		Name_2.text = PlayerPrefs.GetString("Highscore_String_2"); // setting our name1 text to our second highest scoring name
		Name_3.text = PlayerPrefs.GetString("Highscore_String_3"); // setting our name1 text to our third highest scoring name
	}

 	void Player_Entry ()
	{ // setting up our player entry script

		if (Input.GetKeyDown (KeyCode.Return)) { // checking to see if the return key is pressed

			if (Treasure_Pickup.Player_Score == PlayerPrefs.GetFloat ("Highscore")) { // checking to see that the player has the current high score
				PlayerPrefs.SetString("Highscore_String",Enter_Name.text); // setting our high score string to be the text of our text field
			}

			if (Treasure_Pickup.Player_Score == PlayerPrefs.GetFloat ("Highscore2")) { // checking to see that the player has the current second highest score
				PlayerPrefs.SetString("Highscore_String_2",Enter_Name.text); // setting our high score string to be the text of our text field
			}

			if (Treasure_Pickup.Player_Score == PlayerPrefs.GetFloat ("Highscore3")) { // checking to see that the player has the current third highest score
				PlayerPrefs.SetString("Highscore_String_3",Enter_Name.text); // setting our high score string to be the text of our text field
			}


		}


	}

}

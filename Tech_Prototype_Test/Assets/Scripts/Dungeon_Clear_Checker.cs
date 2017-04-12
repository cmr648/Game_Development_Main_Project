using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dungeon_Clear_Checker : MonoBehaviour {

	public static float Enemy_Amount; //creating a public variable for enemy amount
	public float Enemy_Amount_Check; // creating a check variable to see if enemy amount is correct 
	public GameObject Game_End_Panel; // creating a public game object for our game end panel 

	public Text Level_Text; // creating a public text reference for our level show text
	float Current_Level; // creating a float that will track what level we are on

	Color[] Text_Colors = new Color[6]; // Creating an array to assign colors to
	public float Text_Color_Change_Wait; // creating an a float for the text color change wait time

	// Use this for initialization
	void Start () {
	Assign_Text_Colors(); // implementing our assign text colors function

	Level_Text.enabled = false; // disableing the level text at the start of the game
	Current_Level = 0; // setting the current level to one
	Game_End_Panel.SetActive(false); // turning our game panel off at the start of the level
	StartCoroutine("Show_Level"); // implementing and using our show level IEnumerator
	}
	
	// Update is called once per frame
	void Update () {
		Enemy_Amount_Check = Enemy_Amount; // setting the enemy amount check to the enemy amount
		if (Enemy_Amount <= 0) { // checking to see if the dungeon is cleared of enemies
			//Game_End_Panel.SetActive(true); // turning our game end panel on
			StartCoroutine("Show_Level");  // implementing and using our show level IEnumerator
		}

	}

	void FixedUpdate ()
	{ // an update function that is called every frame instead of every rendered frame

		

	}

	IEnumerator Show_Level (){ // creating an IEnumerator to show the level
		Level_Text.color = Text_Colors[Random.Range(0,Text_Colors.Length)]; // picking a random color to assign to our level text
		Level_Text.text = "Level: " + Current_Level; // setting the level text to our current level
		Current_Level = Current_Level +1; // adding a value of one to the current level float
		Level_Text.enabled = true; // enabling the level texts
		yield return new WaitForSeconds(Text_Color_Change_Wait); // waiting one second
		Level_Text.enabled = false; // Disabling the level text
		Level_Text.color = Text_Colors[Random.Range(0,Text_Colors.Length)]; // picking a random color to assign to our level text
		yield return new WaitForSeconds(Text_Color_Change_Wait); // waiting one second
		Level_Text.enabled = true; // enabling the level texts
		yield return new WaitForSeconds(Text_Color_Change_Wait); // waiting one second
		Level_Text.enabled = false; // Disabling the level text
		Level_Text.color = Text_Colors[Random.Range(0,Text_Colors.Length)]; // picking a random color to assign to our level text
		yield return new WaitForSeconds(Text_Color_Change_Wait); // waiting one second
		Level_Text.enabled = true; // enabling the level texts
		yield return new WaitForSeconds(Text_Color_Change_Wait); // waiting one second
		Level_Text.enabled = false; // Disabling the level text

	}

	void Assign_Text_Colors(){ // create a function to assing various color values to
		Text_Colors[0] = Color.blue; // assigning a color to text colors
		Text_Colors[1] = Color.red; // assigning a color to text colors
		Text_Colors[2] = Color.magenta; // assigning a color to text colors
		Text_Colors[3] = Color.yellow; // assigning a color to text colors
		Text_Colors[4] = Color.green; // assigning a color to text colors
		Text_Colors[5] = Color.cyan; // assigning a color to text colors


	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random_Start_Color_Title : MonoBehaviour {

	public Color[] Title_Colors; // creating a public array of random colors

	// Use this for initialization
	void Start () {
		int start_Color_Index = Random.Range(0,Title_Colors.Length); // creating an index to grab the a random number from title colors
		Color Start_Color = new Color(Title_Colors[start_Color_Index].r,Title_Colors[start_Color_Index].g,Title_Colors[start_Color_Index].b); //creatinga  new color from the start clors array

		GetComponent<Text>().color = Start_Color; // setting the text of the titel to one of the random colors in the title colors aray
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

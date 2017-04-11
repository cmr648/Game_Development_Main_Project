using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Room_Start_Screen : MonoBehaviour {

	public GameObject[] Rooms_List; // creating a public list to add random rooms too
	int Room_Choice; // creating a float to assign randomly to choose a random room at the start of the game

	// Use this for initialization


	void Start () {
	Room_Choice = Random.Range(0,Rooms_List.Length); // setting room choice to a random room in our rooms list
	Instantiate(Rooms_List[Room_Choice],gameObject.transform.position,Quaternion.identity); // spawning a random room on top of our empty gameobjct
//
//		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Dungeon_Clear_Checker.Enemy_Amount == 0) { // checking to see if there are no more enmeies left in the dungeon

		}
		
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Spanwer : MonoBehaviour {

	public GameObject[] Rooms_Left; // Creating an array of rooms on the left to later load into the gamemap
	public GameObject[] Rooms_Right; // Creating an array of rooms on the right to later load into the gamemap
	public GameObject[] Rooms_Top; // Creating an array of rooms on the top to later load into the gamemap
	public GameObject[] Rooms_Bottom; // Creating an array pf roms on the top to later load into the gamemap

	public float Room_Spawn_Distance_Left; // creating a public float to edit how far the room will spawn away on the x axis
	public float Room_Spawn_Distance_Right; // creating a public float to edit how far the room will spawn away on the x axis
	public float Room_Spawn_Distance_Top; // creating a public float to edit how far the room wil spawn away on the y axis
	public float Room_Spawn_Distance_Bottom; //creating a public float to edit how far the room will spawn away on the y axis

	public float Camera_Correct_Y; // creating a public float to adjust the room spawn y to fit our camera
	public float Camera_Correct_X; // Creating a public float to adjust the room spawn y to fit our camera

	public int Room_Amount; // Creating a float to adjust the amount of rooms in order to create a random range to select from
	int Room_Index; // creating an int to catalog the number of items in rooms
	Vector3 Camera_Current_Transform; // creating a vector 3 to track the transform of our camera

	
	// Use this for initialization
	void Start () {
		Room_Index = Random.Range(0,Room_Amount); // setting our room index integer to be the number of the length of rooms
	}
	
	// Update is called once per frame
	void Update () {
	Camera_Current_Transform = new Vector3 (Camera.main.transform.position.x,Camera.main.transform.position.y,Camera.main.transform.position.z);  // assinging the current camera transfrom to our camera current transfrom vector3

	}

	void OnTriggerEnter2D (Collider2D col) // using on trigger enter 2d, a void that checks to see if a gameobject has collided with a trigger
	{
		if (col.gameObject.tag == "Room_Spawn_Left") { //an if statement that checks to see if the trigger that the player has entered is the left spawn object
			Instantiate (Rooms_Left [Room_Index], new Vector3 (Camera_Current_Transform.x - Room_Spawn_Distance_Left, Camera_Current_Transform.y + Camera_Correct_Y, Camera_Current_Transform.z + 10), Quaternion.identity); // this is a script that spawns a new room every time we collide with the left spawn gameobject
			 Destroy (col.gameObject); // after we spawn the room we have to destroy the left spawn gameobject
		}

		if (col.gameObject.tag == "Room_Spawn_Right") { //an if statement that checks to see if the trigger that the player has entered is the Right spawn object
			Instantiate (Rooms_Right [Room_Index], new Vector3 (Camera_Current_Transform.x + Room_Spawn_Distance_Right, Camera_Current_Transform.y + Camera_Correct_Y, Camera_Current_Transform.z + 10), Quaternion.identity); // this is a script that spawns a new room every time we collide with the Right spawn gameobject
			Destroy (col.gameObject); // after we spawn the room we have to destroy the Right spawn gameobject
		}

		if (col.gameObject.tag == "Room_Spawn_Top") { //an if statement that checks to see if the trigger that the player has entered is the top spawn object
			Instantiate(Rooms_Top [Room_Index], new Vector3(Camera_Current_Transform.x-Camera_Correct_X,Camera_Current_Transform.y + Room_Spawn_Distance_Top,Camera_Current_Transform.z+10),Quaternion.identity); // this is a script that spawns a new room every time we collide with the top spawn gameobject
			Destroy(col.gameObject); // after we spawn the room we have to destroy the top spawn gameobject
		}


		if (col.gameObject.tag == "Room_Spawn_Bottom") { //an if statement that checks to see if the trigger that the player has entered is the Bottom spawn object
			Instantiate(Rooms_Bottom [Room_Index], new Vector3(Camera_Current_Transform.x-Camera_Correct_X,Camera_Current_Transform.y - Room_Spawn_Distance_Bottom,Camera_Current_Transform.z+10),Quaternion.identity); // this is a script that spawns a new room every time we collide with the Bottom spawn gameobject
			Destroy(col.gameObject); // after we spawn the room we have to destroy the bottom spawn gameobject
		}

	}


}

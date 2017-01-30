using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {
	public float camera_DistanceX; // the distance the camera should move X
	public float camera_DistancyY; // the distance the camera should move Y
	public float camera_Time; // the time a camera should take to move
	//Vector3 Camera_Position_Left; // creating a vector 3 to store an updating camera position for the left side

	float cameraTargetX = 0; // creating an initial float for the target of where we eventually want our camera to move to X
	float cameraTargetY = 0; // creating an initial float for the target of where we eventuually want our camera to move to Y


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{



		float currentX = Camera.main.transform.position.x; // getting the current transform of the camera X
		float setCameraX = currentX += (cameraTargetX - currentX) * 0.1f; // an equation that will always move the cameras position to the correct camera x target that we set
		float currentY = Camera.main.transform.position.y; // getting the current transform of the camera Y
		float setCameraY = currentY += (cameraTargetY - currentY) * 0.1f; //an equation that will always move the cameras position to the correct camera y target that we set

		Camera.main.transform.position = new Vector3(Mathf.Round(setCameraX),Mathf.Round(setCameraY),Camera.main.transform.position.z); //setting our camera position left variable and moving itto the set camera x target Remember mathf.round to make camera snap to grid



	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the players is colliding with the left
			cameraTargetX = Camera.main.transform.position.x - camera_DistanceX; // actually moving the camera to the target poisition. 
			Debug.Log ("Collide");
		} 

		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the players is colliding with the right
			cameraTargetX = Camera.main.transform.position.x + camera_DistanceX; // actually moving the camera to the target poisition. 
			Debug.Log ("Collide");
		} 

		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the players is colliding with the Top
			cameraTargetY = Camera.main.transform.position.y + camera_DistancyY; // actually moving the camera to the target poisition. 
			Debug.Log ("Collide");
		} 

		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the players is colliding with the Bottom
			cameraTargetY = Camera.main.transform.position.y - camera_DistancyY; // actually moving the camera to the target poisition. 
			Debug.Log ("Collide");
		} 



	}
}

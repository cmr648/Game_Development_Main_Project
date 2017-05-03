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

	public GameObject Center_Room;
	public GameObject Center_Room_Top;
	public GameObject Center_Room_Bottom;
	public GameObject Left_Top_Room;
	public GameObject Left_Middle_Room;
	public GameObject Left_Bottom_Room;
	public GameObject Right_Top_Room;
	public GameObject Right_Middle_Room;
	public GameObject Right_Bottom_Room;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 pos = Camera.main.GetComponent<Screen_Shake>().Default_Camera_Position;
		float currentX = pos.x; // getting the current transform of the camera X
		float setCameraX = currentX += (cameraTargetX - currentX) *camera_Time; // an equation that will always move the cameras position to the correct camera x target that we set
		float currentY = pos.y; // getting the current transform of the camera Y
		float setCameraY = currentY += (cameraTargetY - currentY) *camera_Time; //an equation that will always move the cameras position to the correct camera y target that we set

		Camera.main.GetComponent<Screen_Shake>().Default_Camera_Position = new Vector3(setCameraX,setCameraY,Camera.main.transform.position.z); //setting our camera position left variable and moving itto the set camera x target Remember mathf.round to make camera snap to grid



	}

	void OnTriggerEnter2D (Collider2D col) // checking to see if the player is colliding with an objects
	{
//		if (col.gameObject.tag == "Camera_Left_Bounds") { //checking to see if the players is colliding with the left
//			cameraTargetX = Camera.main.transform.position.x - camera_DistanceX; // actually moving the camera to the target poisition. 
//			Debug.Log ("Collide");
//		} 
//
//		if (col.gameObject.tag == "Camera_Right_Bounds") { //checking to see if the players is colliding with the right
//			cameraTargetX = Camera.main.transform.position.x + camera_DistanceX; // actually moving the camera to the target poisition. 
//			Debug.Log ("Collide");
//		} 
//
//		if (col.gameObject.tag == "Camera_Top_Bounds") { //checking to see if the players is colliding with the Top
//			cameraTargetY = Camera.main.transform.position.y + camera_DistancyY; // actually moving the camera to the target poisition. 
//			Debug.Log ("Collide");
//		} 
//
//		if (col.gameObject.tag == "Camera_Bottom_Bounds") { //checking to see if the players is colliding with the Bottom
//			cameraTargetY = Camera.main.transform.position.y - camera_DistancyY; // actually moving the camera to the target poisition. 
//			Debug.Log ("Collide");
//		}

		 if(col.gameObject.tag == "Center_Room"){
		 		cameraTargetY = Center_Room.transform.position.y;
		 		cameraTargetX = Center_Room.transform.position.x;

		   } 

		if(col.gameObject.tag == "Center_Room_Top"){
		 		cameraTargetY = Center_Room_Top.transform.position.y ;
		 		cameraTargetX = Center_Room_Top.transform.position.x;

		   }

		if(col.gameObject.tag == "Center_Room_Bottom"){
		 		cameraTargetY = Center_Room_Bottom.transform.position.y ;
		 		cameraTargetX = Center_Room_Bottom.transform.position.x;

		   }

		if(col.gameObject.tag == "Left_Top_Room"){
		 		cameraTargetY = Left_Top_Room.transform.position.y ;
		 		cameraTargetX = Left_Top_Room.transform.position.x  ;

		   } 

		if(col.gameObject.tag == "Left_Middle_Room"){
		 		cameraTargetY = Left_Middle_Room.transform.position.y;
		 		cameraTargetX = Left_Middle_Room.transform.position.x ;

		   } 

		if(col.gameObject.tag == "Left_Bottom_Room"){
		 		cameraTargetY = Left_Bottom_Room.transform.position.y;
		 		cameraTargetX = Left_Bottom_Room.transform.position.x ;

		   }

		if(col.gameObject.tag == "Right_Top_Room"){
		 		cameraTargetY = Right_Top_Room.transform.position.y ;
		 		cameraTargetX = Right_Top_Room.transform.position.x ;

		   }

		if(col.gameObject.tag == "Right_Middle_Room"){
		 		cameraTargetY = Right_Middle_Room.transform.position.y;
		 		cameraTargetX = Right_Middle_Room.transform.position.x ;

		   }

		if(col.gameObject.tag == "Right_Bottom_Room"){
		 		cameraTargetY = Right_Bottom_Room.transform.position.y ;
		 		cameraTargetX = Right_Bottom_Room.transform.position.x;

		   }



	}
}

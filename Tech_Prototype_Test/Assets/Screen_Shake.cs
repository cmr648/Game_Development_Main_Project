using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Shake : MonoBehaviour {

	public Vector3 Default_Camera_Position; // creating a vector 3 for our default camera position
	Vector3 weightedDirection;
	float Screen_Shake_Timer = 0; // creatinga  a screen shake timer
	float This_Magnitude = 0; // creating a magnitude variable

	// Use this for initialization
	void Start () {
		Default_Camera_Position = transform.position; // setting our default camera position
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Default_Camera_Position = transform.position; // setting our default camera position

		
		if (Screen_Shake_Timer > 0) {
			Vector3 Shake_Direcction = ((Vector3)Random.insideUnitCircle + weightedDirection).normalized * This_Magnitude * Mathf.Clamp01 (Screen_Shake_Timer);

			Vector3 Result = Default_Camera_Position + Shake_Direcction;
			Result.z = -10f;
			transform.position = Result;

			Screen_Shake_Timer -= Time.deltaTime;
		} else {
			transform.position = Default_Camera_Position;
		}
		
	}

	public void Set_Screen_Shake (float magnitude, float duration, Vector3 direction)
	{
		This_Magnitude = magnitude;
		Screen_Shake_Timer = duration;
		weightedDirection = direction;

	}

	public void Set_Screen_Shake (float magnitude, float duration){ // creating a new function for the screen shake
		Set_Screen_Shake(magnitude,duration,Vector3.zero);
	}
}

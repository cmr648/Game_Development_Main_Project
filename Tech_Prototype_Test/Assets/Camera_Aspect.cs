using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Aspect : MonoBehaviour {
	float Original_Width = 1600;
	float Original_Height = 900;

	// Use this for initialization
	void Start () {

	gameObject.GetComponent<Camera>().aspect = (Original_Width/Original_Height) * (Screen.width/Screen.height);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

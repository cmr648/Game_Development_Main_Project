using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Shake : MonoBehaviour {

	Screen_Shake Screenshake_Script;

	// Use this for initialization
	void Start () {

		Screenshake_Script = GetComponent<Screen_Shake>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.Space)) {

			Screenshake_Script.Set_Screen_Shake (1f, 2);
		}
	}
}

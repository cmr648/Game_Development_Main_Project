using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {

public string NextScene; // Creating a public scene to change the next scene we go to 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LevelLoad (){ // creating a public void to accesss in a UI button
		SceneManager.LoadScene(NextScene);  // loading a new scene in which we enter the scene publicly
	}

}

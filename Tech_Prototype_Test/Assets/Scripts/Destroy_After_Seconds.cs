using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_After_Seconds : MonoBehaviour {

	public float Seconds; // creating a public float for seconds of delaty

	// Use this for initialization
	void Start () {

	Destroy(gameObject,Seconds); //destroying an object after our seconds public variable in order to save memory
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

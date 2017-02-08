using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spin : MonoBehaviour {

public float Spin_Speed; // Cretaing a float for the spin speed of the enemy

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	transform.Rotate(Vector3.forward * (Spin_Speed* Time.deltaTime)); // making the transform constantly rotate
		
	}

	void FixedUpdate(){ // an update function that calls every frame instead of every rendered frame
		transform.Rotate(Vector3.forward * (Spin_Speed* Time.deltaTime)); // making the transform constantly rotate
	}
}

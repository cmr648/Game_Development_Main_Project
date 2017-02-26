using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Around_Self : MonoBehaviour {

	public GameObject Rotate_Point; // creating a public gameobjct for the rotate point 
	public float Rotate_Speed; // creating a public float for rotation speed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () // an update function that is called every frame instread of every rendered frame
	{
		
		transform.RotateAround(Rotate_Point.transform.position,Vector3.forward,Rotate_Speed); // having the enemy rotate around an object

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting : MonoBehaviour {

	public GameObject Enemy_Bullet; // Creating a public gameobject for the enemy bullet
	public float Bullet_Time; // Creating a public float for the time it takes to shoot a bullet

	// Use this for initialization
	void Start () {

	InvokeRepeating ("Enemy_Fire",1.0f,Bullet_Time); // having the enemy fire function repeat a certain amount of times
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Enemy_Fire(){ // creating our enemy fire function

		Instantiate(Enemy_Bullet,transform.position,transform.rotation); // using our enemy fire command to instantiate an enmy bullet that will fire

	}
}

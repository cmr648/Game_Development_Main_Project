using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Enemy_Spawn : MonoBehaviour {

	public GameObject[] Enemy_Selection; // creatinga  random enemy for the empty gameobject to select

	// Use this for initialization
	void Start ()
	{

			Instantiate (Enemy_Selection [Random.Range (0, Enemy_Selection.Length)], transform.position, Quaternion.identity);
	

	}
	
	// Update is called once per frame
	void Update () {


		
	}
}

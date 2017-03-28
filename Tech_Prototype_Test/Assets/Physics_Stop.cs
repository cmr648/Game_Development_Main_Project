using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics_Stop : MonoBehaviour {

	BoxCollider2D Physics_Collider; // creating a box collider2d reference to our physics collider

	// Use this for initialization
	void Start () {

	Physics_Collider = GetComponent<BoxCollider2D>(); // assigning the box collider 2d to our physics collider
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKey (KeyCode.W)) { // checking to see if w has been pressed
			Physics_Collider.size = new Vector2 (1.01f, 1.01f); // setting our physics collider to be the proper size
			Physics_Collider.offset = new Vector2 (0,0); // changing the offset of our physics collider

		}

		if (Input.GetKey (KeyCode.S)) { // checking to see if S has been pressed
			Physics_Collider.size = new Vector2 (1.01f, 1.01f); // setting our physics collider to be the proper size
			Physics_Collider.offset = new Vector2 (0,0); // changing the offset of our physics collider

		}

		if (Input.GetKey (KeyCode.A)) { // checking to see if A has been pressed
			Physics_Collider.offset = new Vector2 (0.00426352f, 0.001688957f); // changing the offset of our physics collider
			Physics_Collider.size = new Vector2 (1.387693f, 1.015551f); // setting our physics collider to be the proper size
		}

		if (Input.GetKey (KeyCode.D)) { // checking to see if D has been pressed
			Physics_Collider.offset = new Vector2(-6.151199e-05f,0); // changing the offset of our physics collider
			Physics_Collider.size = new Vector2(1.382978f,1.01f); // changing the size of our physics collider

		}
		
	}
}

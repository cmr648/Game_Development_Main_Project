using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo : MonoBehaviour {

	public static Vector3 ToVector3(float a){ // magic spell to get angle and convert it to a vector3
		return new Vector3 (Mathf.Cos(a*Mathf.Deg2Rad),Mathf.Sin(a * Mathf.Deg2Rad), 0);
	}

}

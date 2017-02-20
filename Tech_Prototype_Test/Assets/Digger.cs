//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Digger : MonoBehaviour {
//
//	public GameObject[] Rooms; 
//	public float digDepth;
//	public List<Vector2> occupiedPositions; 
//	Vector2 curPos;
//	GameObject curRoom;
//	// Use this for initialization
//	void Start ()
//	{
//
//		for (int i = 0; i < digDepth; i++) {
//			curRoom = MakeRoom(curPos);
//			curPos = GetRandomAdjacent(curPos);
//			occupiedPositions.Add(curPos);
//			curRoom.OpenSides();
//		}
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//
//
//
//}

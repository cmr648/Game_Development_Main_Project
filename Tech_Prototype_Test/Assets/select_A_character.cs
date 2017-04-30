using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_A_character : MonoBehaviour {
	public Sprite Player_1;
	public Sprite Player_2;
	float Selection;

	public GameObject Right_Selection_Arrow;
	public GameObject Left_Selection_Arrow;
	public float Arrow_Up_Scale;

	public AudioClip[] Selection_Audio;
	GameObject Sound_Manager;

	// Use this for initialization
	void Start () {
		Selection = PlayerPrefs.GetFloat("Character_Selection");
		Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager");
	}
	
	// Update is called once per frame
	void Update () {
		KeyCommands();
		SpriteChange();
		Arrow_Scaling();
		Debug.Log(Selection);
	}

	void KeyCommands ()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Selection += 1;

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Selection -= 1;

		}

		if (Selection < 0) {
			Selection = 1;

		}

		if (Selection > 1){
			Selection = 0;

		}
	}

	void SpriteChange ()
	{
		if (Selection == 0) {
			gameObject.GetComponent<Image>().sprite = Player_1;
			PlayerPrefs.SetFloat("Character_Selection",0);
		}

		if (Selection == 1) {
			gameObject.GetComponent<Image>().sprite = Player_2;
			PlayerPrefs.SetFloat("Character_Selection",1);

		}

	}

	void Arrow_Scaling ()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Right_Selection_Arrow.transform.localScale = Right_Selection_Arrow.transform.localScale * Arrow_Up_Scale;
			Sound_Manager.GetComponent<Sound>().Playsound(Selection_Audio[Random.Range(0,Selection_Audio.Length)],1);

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Left_Selection_Arrow.transform.localScale = Left_Selection_Arrow.transform.localScale * Arrow_Up_Scale;
			Sound_Manager.GetComponent<Sound>().Playsound(Selection_Audio[Random.Range(0,Selection_Audio.Length)],1);

		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			Right_Selection_Arrow.transform.localScale = Right_Selection_Arrow.transform.localScale / Arrow_Up_Scale;

		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			Left_Selection_Arrow.transform.localScale = Left_Selection_Arrow.transform.localScale / Arrow_Up_Scale;

		}

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_A_character : MonoBehaviour {
	public Sprite Player_1;
	public Sprite Player_2;
	public Sprite Player_3;
	public Sprite Player_4;
	public Sprite Player_5;
	float Selection;

	public GameObject Right_Selection_Arrow;
	public GameObject Left_Selection_Arrow;
	public float Arrow_Up_Scale;

	public AudioClip[] Selection_Audio;
	GameObject Sound_Manager;

	public Text Character_Text;
	public Color[] Character_Text_Color;
	int Color_Index;



	// Use this for initialization
	void Start () {
		Change_Text();

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
			Change_Text();

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Selection -= 1;
			Change_Text();

		}

		if (Selection < 0) {
			Selection = 4;

		}

		if (Selection > 4){
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

		if (Selection == 2) {
			gameObject.GetComponent<Image>().sprite = Player_3;
			PlayerPrefs.SetFloat("Character_Selection",2);


		}

		if (Selection == 3) {
			gameObject.GetComponent<Image>().sprite = Player_4;
			PlayerPrefs.SetFloat("Character_Selection",3);


		}

		if (Selection == 4) {
			gameObject.GetComponent<Image>().sprite = Player_5;
			PlayerPrefs.SetFloat("Character_Selection",4);


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

	void Change_Text(){
		Color_Index = Random.Range(0,Character_Text_Color.Length);
		Character_Text.color = new Color(Character_Text_Color[Color_Index].r,Character_Text_Color[Color_Index].g,Character_Text_Color[Color_Index].b);

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boomerang_UI_Amount : MonoBehaviour {
	public GameObject Boomerang_1;
	public GameObject Boomerang_2;
	public GameObject Boomerang_3;

	public Sprite Boomerang_Normal;
	public Sprite Boomerang_Large;
	public Sprite Boomerang_Small;

	public static float Boomerang_Type_For_UI;

	// Use this for initialization
	void Start () {

	Boomerang_Type_For_UI = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		Boomerang_Color();
		Boomerang_Number_Show();
	}

	void Boomerang_Color ()
	{
		if (Boomerang_Type_For_UI == 0) {
			Boomerang_1.GetComponent<Image>().sprite = Boomerang_Normal;
			Boomerang_2.GetComponent<Image>().sprite = Boomerang_Normal;
			Boomerang_3.GetComponent<Image>().sprite = Boomerang_Normal;

		}

		if (Boomerang_Type_For_UI == 1) {
			Boomerang_1.GetComponent<Image>().sprite = Boomerang_Large;
			Boomerang_2.GetComponent<Image>().sprite = Boomerang_Large;
			Boomerang_3.GetComponent<Image>().sprite = Boomerang_Large;

		}

		if (Boomerang_Type_For_UI == 2) {
			Boomerang_1.GetComponent<Image>().sprite = Boomerang_Small;
			Boomerang_2.GetComponent<Image>().sprite = Boomerang_Small;
			Boomerang_3.GetComponent<Image>().sprite = Boomerang_Small;

		}

	}

	void Boomerang_Number_Show ()
	{
		if (Player_Shooting.Bullet_Limit == 0) {
			Boomerang_1.SetActive(true);
			Boomerang_2.SetActive(true);
			Boomerang_3.SetActive(true);

		}

		if (Player_Shooting.Bullet_Limit == 1) {
			Boomerang_1.SetActive(true);
			Boomerang_2.SetActive(true);
			Boomerang_3.SetActive(false);

		}

		if (Player_Shooting.Bullet_Limit == 2) {
			Boomerang_1.SetActive(true);
			Boomerang_2.SetActive(false);
			Boomerang_3.SetActive(false);

		}

		if (Player_Shooting.Bullet_Limit == 3) {
			Boomerang_1.SetActive(false);
			Boomerang_2.SetActive(false);
			Boomerang_3.SetActive(false);

		}

	}
}

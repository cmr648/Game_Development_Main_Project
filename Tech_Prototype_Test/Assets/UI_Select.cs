using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Select : MonoBehaviour {

	// creating a is muted bool
	bool isMuted;

	// background musci audio source
	public AudioSource Background_Music; 
	public float Volume_Decrease;

	// selector ui
	public GameObject Selector_1;
	public GameObject Selector_2;
	public GameObject Selector_3;
	public GameObject Selector_4;
	public GameObject Selector_5;

	public GameObject Instructions_Panel;
	public GameObject Credits_Panel;
	public GameObject Character_Panel;

	// a number to select things
	public float Selection_Number;

	// a boolean to use arrow keys
	bool Can_Use_Arrow_Keys;
	bool Can_Show_Selection;

	// Button References
	public GameObject Play_Button;
	public GameObject Instructions_Button;
	public GameObject Credits_Button;
	public GameObject Quit_Button;
	public GameObject Mute_Button;
	public GameObject Title_Text;
	public GameObject Character_Select_Text;

	public string Next_level;

	public Animator Fader_Animator;
	public Image Fader;

	GameObject Sound_Manager;
	public AudioClip Show_UI;
	public AudioClip Hide_UI;
	public AudioClip Load_Level_Audio;
	public AudioClip[] Menu_Switch_Audio;

	// Use this for initialization

	void Awake(){
	AudioListener.volume = PlayerPrefs.GetFloat("Mute_Volume");

	}

	void Start () {
		Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager");
		
		Selector_1.SetActive(true);
		Selector_2.SetActive(false);
		Selector_3.SetActive(false);
		Selector_4.SetActive(false);

		Instructions_Panel.SetActive(false);
		Credits_Panel.SetActive(false);
		Character_Panel.SetActive(false);

		Can_Use_Arrow_Keys = true;
		Can_Show_Selection = true;

		Selection_Number = 0;


		Play_Button.SetActive(true);
		Instructions_Button.SetActive(true);
		Credits_Button.SetActive(true);
		Quit_Button.SetActive(true);
		Mute_Button.SetActive(true);
		Title_Text.SetActive(true);
		Character_Select_Text.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Can_Use_Arrow_Keys == true) {
			Arrow_Buttons ();
		}

		Return_Key_Commands ();

		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			Mute();

		}
	}



	void FixedUpdate ()
	{
		AudioListener.volume = PlayerPrefs.GetFloat("Mute_Volume");

		if (Can_Show_Selection == true) {
			Show_Selection ();
		} else {
			Selector_1.SetActive (false);
			Selector_2.SetActive (false);
			Selector_3.SetActive (false);
			Selector_4.SetActive (false);
		}


		if (Fader_Animator.GetBool ("Fade") == true) {
			Check_For_Black ();
			Background_Music.volume -= Volume_Decrease *Time.deltaTime;
		}
	}

	void Arrow_Buttons ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Selection_Number = Selection_Number - 1;
			Sound_Manager.GetComponent<Sound>().Playsound(Menu_Switch_Audio[Random.Range(0,Menu_Switch_Audio.Length)],1);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Selection_Number = Selection_Number + 1;
			Sound_Manager.GetComponent<Sound>().Playsound(Menu_Switch_Audio[Random.Range(0,Menu_Switch_Audio.Length)],1);

		}

		if (Selection_Number > 4) {
			Selection_Number = 0;
		}
		if (Selection_Number <0){
			Selection_Number = 4;
		}
	}

	void Show_Selection ()
	{
		if (Selection_Number == 0) {
			Selector_1.SetActive(true);
			Selector_2.SetActive(false);
			Selector_3.SetActive(false);
			Selector_4.SetActive(false);
			Selector_5.SetActive(false);
		}

		if (Selection_Number == 1) {
			Selector_1.SetActive(false);
			Selector_2.SetActive(true);
			Selector_3.SetActive(false);
			Selector_4.SetActive(false);
			Selector_5.SetActive(false);
		}

		if (Selection_Number == 2) {
			Selector_1.SetActive(false);
			Selector_2.SetActive(false);
			Selector_3.SetActive(true);
			Selector_4.SetActive(false);
			Selector_5.SetActive(false);
		}

		if (Selection_Number == 3) {
			Selector_1.SetActive(false);
			Selector_2.SetActive(false);
			Selector_3.SetActive(false);
			Selector_4.SetActive(true);
			Selector_5.SetActive(false);
		}

		if (Selection_Number == 4) {
			Selector_1.SetActive(false);
			Selector_2.SetActive(false);
			Selector_3.SetActive(false);
			Selector_4.SetActive(false);
			Selector_5.SetActive(true);
		}


	}

	void Return_Key_Commands ()
	{

		if (Input.GetKeyDown (KeyCode.Return) && Selection_Number == 0) {
			Sound_Manager.GetComponent<Sound>().Playsound(Load_Level_Audio,1);
			Fader_Animator.SetBool("Fade",true);

		}

		if (Input.GetKeyDown (KeyCode.Return) && Selection_Number == 1) {
			Sound_Manager.GetComponent<Sound>().Playsound(Show_UI,1);

			Character_Panel.SetActive(true);
			Can_Use_Arrow_Keys = false;
			Can_Show_Selection = false;

			Play_Button.SetActive(false);
			Instructions_Button.SetActive(false);
			Credits_Button.SetActive(false);
			Quit_Button.SetActive(false);
			Mute_Button.SetActive(false);
			Title_Text.SetActive(false);
			Character_Select_Text.SetActive(false);

		}


		if (Input.GetKeyDown (KeyCode.Return) && Selection_Number == 2) {
			Sound_Manager.GetComponent<Sound>().Playsound(Show_UI,1);

			Instructions_Panel.SetActive(true);
			Can_Use_Arrow_Keys = false;
			Can_Show_Selection = false;

			Play_Button.SetActive(false);
			Instructions_Button.SetActive(false);
			Credits_Button.SetActive(false);
			Quit_Button.SetActive(false);
			Mute_Button.SetActive(false);
			Title_Text.SetActive(false);
			Character_Select_Text.SetActive(false);

		}


		if (Input.GetKeyDown (KeyCode.Return) && Selection_Number == 3) {
			Sound_Manager.GetComponent<Sound>().Playsound(Show_UI,1);

			Credits_Panel.SetActive(true);
			Can_Use_Arrow_Keys = false;
			Can_Show_Selection = false;

			Play_Button.SetActive(false);
			Instructions_Button.SetActive(false);
			Credits_Button.SetActive(false);
			Quit_Button.SetActive(false);
			Mute_Button.SetActive(false);
			Title_Text.SetActive(false);
			Character_Select_Text.SetActive(false);

		}


		if (Input.GetKeyDown (KeyCode.Return) && Selection_Number == 3) {
			Application.Quit();
		}

		if(Input.GetKeyDown(KeyCode.Escape) && Instructions_Panel.activeInHierarchy || Input.GetKeyDown(KeyCode.Escape) && Credits_Panel.activeInHierarchy || Input.GetKeyDown(KeyCode.Escape) && Character_Panel.activeInHierarchy){
			Sound_Manager.GetComponent<Sound>().Playsound(Hide_UI,1);


			Can_Use_Arrow_Keys = true;
			Can_Show_Selection = true;
			Instructions_Panel.SetActive(false);
			Credits_Panel.SetActive(false);
			Character_Panel.SetActive(false);

			Play_Button.SetActive(true);
			Instructions_Button.SetActive(true);
			Credits_Button.SetActive(true);
			Quit_Button.SetActive(true);
			Mute_Button.SetActive(true);
			Title_Text.SetActive(true);
			Character_Select_Text.SetActive(true);

		}

	}

	void Check_For_Black ()
	{
		if (Fader.GetComponent<Image>().color.a == 1) {
			SceneManager.LoadScene(Next_level);

		}

	}

	void Mute ()
	{
		isMuted = !isMuted;

		if (isMuted) {
			PlayerPrefs.SetFloat ("Mute_Volume", 0);

		}

		if (!isMuted) {
			PlayerPrefs.SetFloat("Mute_Volume",1);

		}


	}


}

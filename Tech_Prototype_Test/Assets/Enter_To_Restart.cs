using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Enter_To_Restart : MonoBehaviour {

	public string Next_Level;

	public Animator Fader_Animator;
	public GameObject Fader;

	public AudioSource Background_Music;
	public float Volume_Decrease;

	GameObject Sound_Manager;
	public AudioClip Load_Level_Audio;

	// Use this for initialization
	void Start () {
		Sound_Manager = GameObject.FindGameObjectWithTag("Sound_Manager");
	}
	
	// Update is called once per frame
	void Update () {
		Return_Key();
	}

	void FixedUpdate ()
	{
		if (Fader_Animator.GetBool ("Fade") == true) {
			Check_For_Black();
			Background_Music.volume -= Volume_Decrease *Time.deltaTime;
		}

	}

	void Return_Key ()
	{
		if (Input.GetKeyDown (KeyCode.Return)) {
			Fader_Animator.SetBool("Fade",true);
			Sound_Manager.GetComponent<Sound>().Playsound(Load_Level_Audio,1);

		}

	}

	void Check_For_Black ()
	{
		if (Fader.GetComponent<Image> ().color.a == 1) {
			SceneManager.LoadScene(Next_Level);
		}

		

	}


}

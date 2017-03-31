using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	public static Sound Main_Sound; // creating a main sound to edit
	public GameObject audio_Source; // creating a public audio source to edit
	public AudioSource[] Audio_Sources; // creating an array of audio sources


	// Use this for initialization
	void Start ()
	{
		Audio_Sources = new AudioSource[32];
		for (int i = 0; i < Audio_Sources.Length; i++) {
		Audio_Sources[i] = (Instantiate(audio_Source,Vector3.zero, Quaternion.identity) as GameObject).GetComponent<AudioSource>();

		}
 	}

 	public void Playsound (AudioClip snd, float vol) 
 	{
	int sNum = GetSourceNum();
	Audio_Sources[sNum].clip = snd;
	Audio_Sources[sNum].volume = vol;
	Audio_Sources[sNum].Play();
	}

	public int GetSourceNum ()
	{
		for (int i = 0; i < Audio_Sources.Length; i++) {
			if (!Audio_Sources[i].isPlaying){
				return i;
		}
	}

		return 0;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}

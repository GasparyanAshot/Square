using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour {

	public GameObject MusicOn;
	public GameObject MusicOff;
	public AudioMixer Music;

	public GameObject SoundsOn;
	public GameObject SoundsOff;
	public AudioMixer Sounds;

	void Start () {
		if (PlayerPrefs.GetFloat ("Music") == 20) {
			MusicOn.SetActive (true);
			MusicOff.SetActive (false);
		} else {
			MusicOn.SetActive (false);
			MusicOff.SetActive (true);
		}
		if (PlayerPrefs.GetFloat ("Sounds") == 0) {
			SoundsOn.SetActive (true);
			SoundsOff.SetActive (false);
		} else {
			SoundsOn.SetActive (false);
			SoundsOff.SetActive (true);
		}
	}

	void Update () {
		
	}

	public void SetMusicOn(){
		MusicOn.SetActive (true);
		MusicOff.SetActive (false);
		PlayerPrefs.SetFloat ("Music",20);
		Music.SetFloat ("MusicVol",20);
	}

	public void SetMusicOff(){
		MusicOn.SetActive (false);
		MusicOff.SetActive (true);
		PlayerPrefs.SetFloat ("Music",-80f);
		Music.SetFloat ("MusicVol",-80f);
	}

	public void SetSoundsOn(){
		SoundsOn.SetActive (true);
		SoundsOff.SetActive (false);
		PlayerPrefs.SetFloat ("Sounds",0);
		Sounds.SetFloat ("SoundsVol",0);
	}

	public void SetSoundsOff(){
		SoundsOn.SetActive (false);
		SoundsOff.SetActive (true);
		PlayerPrefs.SetFloat ("Sounds",-80f);
		Sounds.SetFloat ("SoundsVol",-80f);
	}
}

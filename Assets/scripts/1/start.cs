using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class start : MonoBehaviour {

	public Text HighestScore;
	public Text Coins;
	public AudioMixer Music;
	public AudioMixer Sounds;


	void Start(){
		HighestScore.text = PlayerPrefs.GetFloat ("HighestScore").ToString();
		Coins.text = PlayerPrefs.GetFloat ("Coins").ToString ();
		Music.SetFloat ("MusicVol",PlayerPrefs.GetFloat("Music"));
		Sounds.SetFloat ("SoundsVol",PlayerPrefs.GetFloat("Sounds"));
	}

	public void Play(){
		SceneManager.LoadScene ("1");
		Time.timeScale = 1;
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.F)){
			PlayerPrefs.SetFloat ("Coins",0);
			PlayerPrefs.SetFloat ("HighestScore",0);
			HighestScore.text = PlayerPrefs.GetFloat ("HighestScore").ToString();
			Coins.text = PlayerPrefs.GetFloat ("Coins").ToString ();
			PlayerPrefs.SetInt ("SkinNum",0);
			PlayerPrefs.SetFloat ("Music",0);
			Music.SetFloat ("MusicVol",0);
			PlayerPrefs.SetFloat ("Sounds",0);
			Sounds.SetFloat ("SoundsVol",0);
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			PlayerPrefs.SetFloat ("Coins",1000000);
			PlayerPrefs.SetFloat ("HighestScore",1000);
			HighestScore.text = PlayerPrefs.GetFloat ("HighestScore").ToString();
			Coins.text = PlayerPrefs.GetFloat ("Coins").ToString ();
		}
		if(Input.GetKeyDown (KeyCode.E)){
			PlayerPrefs.SetInt ("Skin1",0);
			PlayerPrefs.SetInt ("Skin2",0);
			PlayerPrefs.SetInt ("Skin3",0);
			PlayerPrefs.SetInt ("Skin4",0);
			PlayerPrefs.SetInt ("Skin5",0);
			PlayerPrefs.SetInt ("Skin6",0);
			PlayerPrefs.SetInt ("Skin7",0);
		}

	}

	public void SetCoins(float coins){
		Coins.text = coins.ToString ();
	}
		
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class gameController : MonoBehaviour {

	public Text score;
	public float Scorefloat;
	public bool gameover = false;
	public GameObject GameOverMenu;
	public Text FinishScore;
	public float Speed;
	public float Coinsfloat;
	public Text Coins;
	public float coinsNumber;
	public float HighestScore=0;
	public GameObject NewRecord;
	bool SetNewRecord=false;
	public GameObject PauseMenu;
	public bool Paused=false;
	public AudioSource record;
	public AudioSource music;


	public float CD;

	void Update(){
		if(SetNewRecord==false && Scorefloat>0 && Scorefloat>PlayerPrefs.GetFloat("HighestScore")){
		record.Play ();
		NewRecord.SetActive (true);
		SetNewRecord = true;
		Invoke ("StopNewRecord",3);
		}
	}

	public void Score (){
		Scorefloat += 1f;
		score.text = Scorefloat.ToString ();
	}

	public void GameOver(){
		music.Stop ();
		GameOverMenu.SetActive (true);
		Paused = true;
		FinishScore.text = Scorefloat.ToString ();
		if(Scorefloat>PlayerPrefs.GetFloat("HighestScore")){
			NewHighestScore();
		}
		CoinsNumber ();
		gameover = true;
	}

	public void Restart(){
		SetNewRecord = false;
		Paused = false;
		SceneManager.LoadScene ("1");
		UnPause ();
	}

	public void SpeedUp(){
		Speed += 0.03f;
	}

	public void CDUp(){
		CD -= 0.02f;
	}

	public void Coin(){
		Coinsfloat += 1f;
		Coins.text = Coinsfloat.ToString ();
	}

	public void NewHighestScore(){
		HighestScore = Scorefloat;
		PlayerPrefs.SetFloat ("HighestScore",HighestScore);
	}

	void StopNewRecord(){
		NewRecord.SetActive (false);
	}

	public void Home(){
		SceneManager.LoadScene ("Start",LoadSceneMode.Single);
		Paused = false;
		if(Scorefloat>PlayerPrefs.GetFloat("HighestScore")){
			NewHighestScore();
		}
		CoinsNumber ();
	}

	public void CoinsNumber(){
		coinsNumber = Coinsfloat + PlayerPrefs.GetFloat ("Coins");
		PlayerPrefs.SetFloat ("Coins",coinsNumber);
	}

	public void Pause(){
		if(gameover==false){
		music.Stop ();
		PauseMenu.SetActive (true);
		Paused = true;
		}
	}

	public void UnPause(){
		music.Play ();
		Paused = false;
	}
}

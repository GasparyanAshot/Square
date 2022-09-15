using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedSkin : MonoBehaviour {


	public bool ByCoin;
	public float Price;
	public start StartScript;
	public string SkinName;
	bool unlocked=false;


	void Start (){
		if(PlayerPrefs.GetInt(SkinName)==1){
			gameObject.SetActive (false);
		}
	}

	public void Unlock(){
		if(ByCoin){
			if(Price<=PlayerPrefs.GetFloat("Coins")&& unlocked==false){
				unlocked = true;
				PlayerPrefs.SetInt(SkinName,1);
			}
		}
		else{
			if(Price<=PlayerPrefs.GetFloat("HighestScore")&& unlocked==false){
				unlocked = true;
			gameObject.SetActive (false);
				PlayerPrefs.SetInt (SkinName,1);
			}
		}
	}

	public void CoinSet(){
		if (Price<=PlayerPrefs.GetFloat("Coins") && ByCoin==true) {
			PlayerPrefs.SetFloat ("Coins", PlayerPrefs.GetFloat ("Coins") - Price);
			StartScript.SetCoins (PlayerPrefs.GetFloat ("Coins"));
			gameObject.SetActive (false);
		}
	}

}

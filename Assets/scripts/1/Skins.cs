using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour {

	public int Skin;

	public GameObject Skin0;
	public GameObject Skin1;
	public GameObject Skin2;
	public GameObject Skin3;
	public GameObject Skin4;
	public GameObject Skin5;
	public GameObject Skin6;
	public GameObject Skin7;
	public GameObject Skin8;
	public GameObject Skin9;

	public bool Game=false;


	void Start(){
		if(Game){
		Skin = PlayerPrefs.GetInt ("SkinNum");
			GameObject[] skins=new GameObject[10]{Skin0,Skin1,Skin2,Skin3,Skin4,Skin5,Skin6,Skin7,Skin8,Skin9};
		skins [Skin].SetActive (true);
		}
	}

	public void SetSkin(int num){
		PlayerPrefs.SetInt ("SkinNum",num);
	}

}

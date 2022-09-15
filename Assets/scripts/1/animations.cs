using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour {

	public Animation PlayButton;

	void StartAnims () {
		PlayButton.Play ("PlayButton");
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.A)) {
			PlayButton.Play ("PlayButton");
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			PlayButton.Stop ("PlayButton");
		}
	}
	

}

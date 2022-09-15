using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public int coordX;
	public int coordY;

	public ParticleSystem StepParticle;

	public gameController gameControl;
	public coin Coin;


	public void Up(){
		Step ();
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1.76f, gameObject.transform.position.z);
		coordY += 1;
	}
	public void Down(){
		Step ();
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y - 1.76f, gameObject.transform.position.z);
		coordY -= 1;
	}
	public void Left(){
		Step ();
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x - 1.76f, gameObject.transform.position.y, gameObject.transform.position.z);
		coordX -= 1;
	}
	public void Right(){
		Step ();
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 1.76f, gameObject.transform.position.y, gameObject.transform.position.z);
		coordX += 1;
	}

	void Step(){
		StepParticle.transform.position = gameObject.transform.position;
		StepParticle.Play();
		Invoke ("StepParticleStop",0.2f);
	}

	void StepParticleStop(){
		StepParticle.Stop();
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="Enemy"){
			gameControl.GameOver ();
			Destroy (gameObject);
		}
		if(other.gameObject.tag=="Coin"){
			gameControl.Coin ();
			Coin.Tp ();
		}
	}
}

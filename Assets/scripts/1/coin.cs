using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	public float X;
	public float Y;

	public AudioSource Coin;

	void Start(){
		Tp ();
	}

	public void Tp(){
		Coin.Play ();

		X = Random.Range (1, 4);

		while(transform.position.x==3.52f-X*1.76f){
			X = Random.Range (1, 4);
		}

		Y = Random.Range (1, 4);

		while(transform.position.y==3.52f-Y*1.76f){
			Y = Random.Range (1, 4);
		}

		transform.position = new Vector2 (3.52f-X*1.76f,3.52f-Y*1.76f);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_horizontal : MonoBehaviour {

	public bool Right;
	public float Speed;
	public gameController GameControl;
	public GameObject Camera;

	void Start(){
		Camera = GameObject.Find ("Main Camera");
		GameControl = Camera.GetComponent<gameController>();
		if(transform.position.x<0){
			Right=false;
		}
		Speed = GameControl.Speed;
	}


	void FixedUpdate () {
		if(GameControl.Paused==false){
		if(Right==false){
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		if(Right){
			transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="Border"){
			Destroy (gameObject);
		}
		if(other.gameObject.tag=="ScoreCheck"){
			if(transform.position.x<-1 && Right){
				GameControl.Score ();
			}
			if(transform.position.x>1 && Right==false){
				GameControl.Score ();
			}
		}
	}
}

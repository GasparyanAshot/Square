using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_vertical : MonoBehaviour {

	public bool Up;
	public float Speed;
	public gameController GameControl;
	public GameObject Camera;

	void Start(){
		Camera = GameObject.Find ("Main Camera");
		GameControl = Camera.GetComponent<gameController>();
		transform.rotation= Quaternion.AngleAxis(90,Vector3.forward);
		if(transform.position.y<0){
			Up=false;
		}
		Speed = GameControl.Speed;
	}


	void FixedUpdate () {
		if (GameControl.Paused == false) {
			if (Up == false) {
				transform.Translate (Vector3.right * Speed * Time.deltaTime);
			}
			if (Up) {
				transform.Translate (Vector3.left * Speed * Time.deltaTime);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag=="Border"){
			Destroy (gameObject);
		}
	}
}

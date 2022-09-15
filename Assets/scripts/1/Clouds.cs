using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour {

	public float Speed;
	public float StartX;
	public float EndX;

	void Start () {
		
	}
	

	void FixedUpdate () {
		if (gameObject.transform.position.x> 1000) {
			Speed = -Speed;
		}
		if (gameObject.transform.position.x < -1000) {
			Speed = -Speed;
		}
		transform.Translate (Vector3.right * Speed * Time.deltaTime);
	}
}

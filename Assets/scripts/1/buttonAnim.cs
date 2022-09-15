using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnim : MonoBehaviour {

	public Animation anim;

	public void StartAnim(){
		anim.Play ("Skin");
	}

	public void AnimBack(){
		anim.Play ("SkinBack");
	}

}

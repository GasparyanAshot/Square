using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class touchcontroll : MonoBehaviour,IBeginDragHandler,IDragHandler {

	public player Player;


	public void OnBeginDrag(PointerEventData eventData){
		if((Mathf.Abs(eventData.delta.x))>(Mathf.Abs(eventData.delta.y))){
			if(eventData.delta.x>3 && Player.coordX<3){
			Player.Right ();
			}
			if(eventData.delta.x<3 && Player.coordX>1){
				Player.Left ();
			}
		}
		if((Mathf.Abs(eventData.delta.x))<(Mathf.Abs(eventData.delta.y))){
			if(eventData.delta.y>3 && Player.coordY<3){
				Player.Up ();
			}
			if(eventData.delta.y<3 && Player.coordY>1){
				Player.Down ();
			}
		}
	}

	public void OnDrag(PointerEventData eventData){

	}
}

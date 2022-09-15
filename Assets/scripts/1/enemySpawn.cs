using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

	public float CD;

	public GameObject HorizontalEnemy;
	public GameObject VerticalEnemy;
	public GameObject HintHorizontal;
	public GameObject HintVertical;

	public int SpawnCoord;
	public int SpawnSide;

	public gameController gameControl;

	void Start () {
		HorizontalSpawn ();
		VerticalSpawn ();
	}

	void Update () {
		
	}


	public void HorizontalSpawn(){
		if(gameControl.gameover==false && gameControl.Paused == false){
		SpawnCoord = Random.Range (1,4);
		SpawnSide = Random.Range (1,3);
		if(SpawnSide==1){
			Instantiate (HorizontalEnemy,new Vector2(7f,3.52f-SpawnCoord*1.76f),Quaternion.identity);
			HintHorizontal.transform.position = new Vector2 (1.76f,3.52f-SpawnCoord*1.76f);
			HintHorizontal.transform.rotation= Quaternion.AngleAxis(0,Vector3.forward);
		}
		if(SpawnSide==2){
			Instantiate (HorizontalEnemy,new Vector2(-7f,3.52f-SpawnCoord*1.76f),Quaternion.identity);
			HintHorizontal.transform.position = new Vector2 (-1.76f,3.52f-SpawnCoord*1.76f);
			HintHorizontal.transform.rotation= Quaternion.AngleAxis(180,Vector3.forward);
		}
			gameControl.SpeedUp ();
			gameControl.CDUp ();
			CD = gameControl.CD;
		}
		Invoke ("HorizontalSpawn",CD);
	}

	public void VerticalSpawn(){
		if (gameControl.gameover == false && gameControl.Paused == false) {
			SpawnCoord = Random.Range (1, 4);
			SpawnSide = Random.Range (1, 3);
			if (SpawnSide == 1) {
				Instantiate (VerticalEnemy, new Vector2 (3.52f - SpawnCoord * 1.76f, 7f), Quaternion.identity);
				HintVertical.transform.position = new Vector2 (3.52f - SpawnCoord * 1.76f, 1.76f);
				HintVertical.transform.rotation = Quaternion.AngleAxis (0, Vector3.forward);
			}
			if (SpawnSide == 2) {
				Instantiate (VerticalEnemy, new Vector2 (3.52f - SpawnCoord * 1.76f, -7f), Quaternion.identity);
				HintVertical.transform.position = new Vector2 (3.52f - SpawnCoord * 1.76f, -1.76f);
				HintVertical.transform.rotation = Quaternion.AngleAxis (180, Vector3.forward);
			}
			  gameControl.SpeedUp ();
			  gameControl.CDUp ();
			  CD = gameControl.CD;
		}
		Invoke ("VerticalSpawn", CD);
	}
}

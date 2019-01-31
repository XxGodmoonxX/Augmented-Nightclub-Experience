using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Placenote;
using UnityEngine.UI;


public class BreakOutText : PlacenotePunMultiplayerBehaviour {

  private Text breakOutText;

	public GameObject soundObject;


	int id; //PhotonNetwork.player.ID を入れる

	GameObject[] BreakOutCubeTags; //BreakOutCubeってタグついてるGameobject取得する用

	int CubeBlueNum = 0;
	int CubeRedNum = 0;

	float volume; //音量取得用

	void Awake() {
    breakOutText = gameObject.GetComponent<Text> ();
		BreakOutCubeTags = GameObject.FindGameObjectsWithTag ("BreakOutCube"); //BreakOutCubeってタグついてるGameobject取得
	}

	void OnJoinedRoom() {
		id = PhotonNetwork.player.ID; //PhotonNetwork.player.ID を入れる
	}

	void update() {
	}

	public void breakOutAwake() {
		breakOutText.text = "BreakOut Awake!!!" + id.ToString();
	}

	// Use this for initialization
	public void breakOutStart () {
		breakOutText.text = "Start!!!";
	}

	public void breakOutOnGameStart() {
		breakOutText.text = "onGameStart!!!";
	}

	// Update is called once per frame
	public void breakOutUpdate () {
		// Debug.Log(BreakOutCubeTags.length);
		// for (int i = 0; i < BreakOutCubeTags.length; i++) {
		// 	if (BreakOutCubeTags[i].GetComponent<Renderer>().material.color == new Color(0, 0, 1.0f, 0.5f)) { //Cube青くなってる数
		// 		CubeBlueNum ++;
		// 	}
		// 	if (BreakOutCubeTags[i].GetComponent<Renderer>().material.color == new Color(1.0f, 0, 0, 0.5f)) { //Cube赤くなってる数
		// 		CubeRedNum ++;
		// 	}
		// }

		// breakOutText.text = "Update!!!" + id.ToString();
		breakOutText.text = "ID" + id.ToString();
		// breakOutText.text = "Update!!!" + id.ToString() + CubeBlueNum.ToString() + CubeRedNum.ToString();

		// volume = soundObject.GetComponent<sound>().volume;

	}

	public void breakOutInstantiate () {
		breakOutText.text = "Instantiate!!!";
	}

	public void breakOutDestroy () {
		breakOutText.text = "Destroy!!!";
	}

	public void breakOutCollision () {
		breakOutText.text = "Collision!!!";
	}
}

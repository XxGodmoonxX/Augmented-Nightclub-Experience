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

	public GameObject blueSphere;
	int blueSphereCollisionNum = 0;
	int blueSphereTapNum = 0;

	int tapNum;

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
		// for (int i = 0; i < 972; i++) {
		// 	if (BreakOutCubeTags[i].GetComponent<Renderer>().material.color == Color(0, 0, 1.0f, 0.5f)) { //Cube青くなってる数
		// 		CubeBlueNum ++;
		// 	}
		// 	if (BreakOutCubeTags[i].GetComponent<Renderer>().material.color == Color(1.0f, 0, 0, 0.5f)) { //Cube赤くなってる数
		// 		CubeRedNum ++;
		// 	}
		// }

		// breakOutText.text = "Update!!!" + id.ToString();
		// breakOutText.text = "ID" + id.ToString();
		// breakOutText.text = "Update!!!" + id.ToString() + CubeBlueNum.ToString() + CubeRedNum.ToString();

		// volume = soundObject.GetComponent<sound>().volume;

		// blueSphereCollisionNum = blueSphere.GetComponent<BlueSphereController>().collisionNum;
		// blueSphereTapNum = blueSphere.GetComponent<BlueSphereController>().tapNum;
		// Debug.Log(blueSphereTapNum);

		// breakOutText.text = "Collision" + blueSphereCollisionNum.ToString() + "Tap" + blueSphereTapNum.ToString();
		breakOutText.text = "Collision" + blueSphereCollisionNum.ToString();

	}

	int num = 0;
	public void breakOutInstantiate () {
		breakOutText.text = "Instantiate!!!";
		blueSphereTapNum ++; //0 2 5 9 14 20 27
	}

	public void breakOutDestroy () {
		breakOutText.text = "Destroy!!!";
	}

	public void breakOutCollision () {
		breakOutText.text = "Collision!!!";
		blueSphereCollisionNum++;
	}
}

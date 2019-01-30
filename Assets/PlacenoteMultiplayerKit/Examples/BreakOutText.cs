using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Placenote;
using UnityEngine.UI;


public class BreakOutText : PlacenotePunMultiplayerBehaviour {

  private Text breakOutText;

	int id; //PhotonNetwork.player.ID を入れる

	void Awake() {
    breakOutText = gameObject.GetComponent<Text> ();
	}

	void OnJoinedRoom() {
		id = PhotonNetwork.player.ID;
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
		breakOutText.text = "Update!!!" + id.ToString();
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

	void update() {
		breakOutText.text = "Update in breakouttext.cs";
	}
}

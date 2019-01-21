using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Placenote;
using UnityEngine.UI;


public class BreakOutText : PlacenotePunMultiplayerBehaviour {

  private Text breakOutText;

	void Awake() {
    breakOutText = gameObject.GetComponent<Text> ();
	}

	public void breakOutAwake() {
		breakOutText.text = "BreakOut Awake!!!";
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
		breakOutText.text = "Update!!!";
	}

	public void breakOutInstantiate () {
		breakOutText.text = "Instantiate!!!";
	}

	public void breakOutDestroy () {
		breakOutText.text = "Destroy!!!";
	}

	void update() {
		breakOutText.text = "Update in breakouttext.cs";
	}
}

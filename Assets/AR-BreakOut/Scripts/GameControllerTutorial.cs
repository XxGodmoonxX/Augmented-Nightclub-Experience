using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Placenote
using Placenote;
using UnityEngine.XR.iOS;

using UnityEngine.UI; //Text使うため


// namespace UnityEngine.XR.iOS
// {
public class GameControllerTutorial : PlacenotePunMultiplayerBehaviour {

	float x = 0;
	float y = 0;
	float z = 0;
	// Vector3 position = (x, y, z);

	public Camera cam;

	public Transform m_HitTransform;
	public float maxRayDistance = 30.0f;
	public LayerMask collisionLayer = 1 << 10;  //ARKitPlane layer

	public GameObject debugCanvas; //Text

  // protected virtual void OnRoomListUpdate () { 
	// 	Text debug_text = debugCanvas.GetComponent<Text>();
	// 	debug_text.text = "OnRoomListUpdate";
	// }


	protected override void OnJoinedRoom() {
		Debug.Log("JoinTheRoom!!!");
	}

	protected override void OnGameStart() {
		Debug.Log("GameStart");

		PhotonNetwork.Instantiate("player", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("shadowPlane", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
		PhotonNetwork.Instantiate("Sphere", Vector3.forward, Quaternion.identity, 0);
		
		Text debug_text = debugCanvas.GetComponent<Text>();
		debug_text.text = "OnGameStart";
	}

	void start() {
		Text debug_text = debugCanvas.GetComponent<Text>();
		debug_text.text = "start";
	}

	void update() {
		Debug.Log("update");
		Text debug_text = debugCanvas.GetComponent<Text>();
		debug_text.text = 10.ToString();
	}

	protected override void OnPlayerValueUpdate() {
		Text debug_text = debugCanvas.GetComponent<Text>();
		debug_text.text = "update";

	}

}
// }
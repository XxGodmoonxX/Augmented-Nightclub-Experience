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

	public Camera cam;

	protected override void OnGameStart() {
		Debug.Log("GameStart");

		PhotonNetwork.Instantiate("player", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("shadowPlane", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
		PhotonNetwork.Instantiate("Sphere", Vector3.forward, Quaternion.identity, 0);
	}

}
// }
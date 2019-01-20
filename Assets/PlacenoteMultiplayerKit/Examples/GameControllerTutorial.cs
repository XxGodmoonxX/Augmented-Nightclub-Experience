﻿using System.Collections;
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

	public GameObject imageanchor;

	protected override void OnGameStart() {

		PhotonNetwork.Instantiate("player", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("shadowPlane", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
		PhotonNetwork.Instantiate("Sphere", Vector3.zero, Quaternion.identity, 0);

		//画像認識
		imageanchor.GetComponent<PhotonGenerateImageAnchor>().returnAccess();
		imageanchor.GetComponent<PhotonGenerateImageAnchor>().Start();
	}

	void update() {

	}

}
// }
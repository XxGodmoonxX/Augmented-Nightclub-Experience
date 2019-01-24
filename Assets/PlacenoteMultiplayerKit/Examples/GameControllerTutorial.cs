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

	public Camera cam;

	public GameObject imageanchor;
  public GameObject breakOutText;
  public GameObject blueSphereController;
	public GameObject soundObject;
	public GameObject fromCube;

	void Awake() {
    breakOutText.GetComponent<BreakOutText>().breakOutAwake();
	}

	protected override void OnGameStart() {
    breakOutText.GetComponent<BreakOutText>().breakOutOnGameStart();

		// PhotonNetwork.Instantiate("player", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("shadowPlane", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("Sphere", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("Sphere", Vector3.forward, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("Sphere", Vector3.right, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("RedSphere", cam.transform.TransformPoint(0, 0, 5f), Quaternion.identity, 0);
		PhotonNetwork.Instantiate("BlueSphere", cam.transform.TransformPoint(0, 0, 5f), Quaternion.identity, 0);
		// blueSphereController.GetComponent<BlueSphereController>().Start();
		// blueSphereController.GetComponent<BlueSphereController>().Update();

		//画像認識
		imageanchor.GetComponent<PhotonGenerateImageAnchor>().returnAccess();
		imageanchor.GetComponent<PhotonGenerateImageAnchor>().Start();
		//
		// soundObject.GetComponent<sound>().Start();
		// soundObject.GetComponent<sound>().Update();
		//
		// fromCube.GetComponent<FromCube>().Start();
		// fromCube.GetComponent<FromCube>().Update();
	}

	void update() {
    // breakOutText.GetComponent<BreakOutText>().breakOutUpdate();
	}

}
// }
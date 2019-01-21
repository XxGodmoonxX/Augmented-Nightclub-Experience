using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text使うため

public class SphereController : Photon.MonoBehaviour {

  public Transform CameraTransform;
  public GameObject breakOutText;

	// Use this for initialization
	void Start () {
    CameraTransform = FindObjectOfType<Camera> ().transform;

		// Register this object to the current game controller.
    // This is important so that all clients have a reference to this object.
     GameController.Instance.RegisterSphere (this);
	}
	
	// Update is called once per frame
	void Update () {
		// If this player is not being controlled by the local client
    // then do not update its position. Each client is responsible to update
    // its own player.
		//恐らく自分からは見えないけど相手からは見える、ように、のはず。
    if (!photonView.isMine && PhotonNetwork.connected) {
    	return;
		}

		// The player should have the same transform as the camera
    gameObject.transform.position = CameraTransform.position;
    gameObject.transform.rotation = CameraTransform.rotation;
		
		//タップしたら1回発動
  	if (0 < Input.touchCount) {
      if (Input.GetTouch(0).phase == TouchPhase.Began) {
				// Register this object to the current game controller.
				// This is important so that all clients have a reference to this object.
		    // breakOutText.GetComponent<BreakOutText>().breakOutUpdate();
				// GameController.Instance.RegisterSphere (this);
			}
		}
	}
}

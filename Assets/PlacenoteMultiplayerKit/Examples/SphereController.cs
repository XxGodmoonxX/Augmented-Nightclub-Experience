using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereController : Photon.MonoBehaviour {

  public Transform CameraTransform;

	// Use this for initialization
	void Start () {
		// Register this object to the current game controller.
    // This is important so that all clients have a reference to this object.
    //  GameController.Instance.RegisterSphere (this);
	}
	
	// Update is called once per frame
	void Update () {
		// The player should have the same transform as the camera
    gameObject.transform.position = CameraTransform.position;
    gameObject.transform.rotation = CameraTransform.rotation;
		
		//タップしたら1回発動
  	if (0 < Input.touchCount) {
      if (Input.GetTouch(0).phase == TouchPhase.Began) {
				// Register this object to the current game controller.
				// This is important so that all clients have a reference to this object.
				GameController.Instance.RegisterSphere (this);
			}
		}
	}
}

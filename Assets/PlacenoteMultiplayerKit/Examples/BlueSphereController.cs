using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text使うため

public class BlueSphereController : Photon.MonoBehaviour {

  public Transform CameraTransform;
  public GameObject breakOutText;

	byte i = 0;

	// int id = PhotonNetwork.player.ID;

	// Use this for initialization
	public void Start () {
    CameraTransform = FindObjectOfType<Camera> ().transform;
		breakOutText = GameObject.Find("BreakOutText");

		// Register this object to the current game controller.
    // This is important so that all clients have a reference to this object.
    // GameController.Instance.RegisterSphere (this);

		// InvokeRepeating("destroy", 2f, 2f);
		// InvokeRepeating("startBlueSphere", 2.5f, 2f);
	}
	
	// Update is called once per frame
	public void Update () {
		// If this player is not being controlled by the local client
    // then do not update its position. Each client is responsible to update
    // its own player.
		//恐らく自分からは見えないけど相手からは見える、ように、のはず。と思いきや違った。自分から見えてないところじゃないとポジション更新しない的なはず。
    if (!photonView.isMine && PhotonNetwork.connected) {
    	return;
		}

		breakOutText.GetComponent<BreakOutText>().breakOutUpdate();
		int id = PhotonNetwork.player.ID;

		// GameController.Instance.RegisterSphere(b);

		// The player should have the same transform as the camera
    // gameObject.transform.position = CameraTransform.position;
    // gameObject.transform.rotation = CameraTransform.rotation;

		//タップしたら1回発動
  	if (0 < Input.touchCount) {
      if (Input.GetTouch(0).phase == TouchPhase.Began) {
			//画面触っている間
      // if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Moved) {
				// Register this object to the current game controller.
				// This is important so that all clients have a reference to this object.
		    breakOutText.GetComponent<BreakOutText>().breakOutInstantiate();

				// PhotonNetwork.Instantiate("BlueSphere", Vector3.zero, Quaternion.identity, 0);
				// BlueSphere.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0, 0, 7f),ForceMode.Impulse);
				if (id == 1) {
					PhotonNetwork.Instantiate("BlueSphere", CameraTransform.position, Quaternion.identity, i);
				}
				if (id == 2) {
					// PhotonNetwork.Instantiate("RedSphere", CameraTransform.position, Quaternion.identity, i);
				}
				// PhotonNetwork.Instantiate("BlueSphere", CameraTransform.TransformDirection(0, 0, 7f), Quaternion.identity, i);
				i++;
			}
		}
		//タップ終わり
  	// if (0 < Input.touchCount) {
    // 	if (Input.GetTouch(0).phase == TouchPhase.Ended) {
		//     breakOutText.GetComponent<BreakOutText>().breakOutDestroy();
		// 		PhotonNetwork.Destroy(this.photonView);
		// 	}
		// }
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("BreakOutCube")) {
			breakOutText.GetComponent<BreakOutText>().breakOutCollision();
			Destroy(collision.gameObject);
		}
	}

	// void startBlueSphere() {
	// 	PhotonNetwork.Instantiate("BlueSphere", CameraTransform.transform.TransformPoint(0, 0, 5f), Quaternion.identity, 0);
	// }

	// void destroy() {
	// 	PhotonNetwork.Destroy(this.photonView);
	// 	breakOutText.GetComponent<BreakOutText>().breakOutDestroy();
	// }
}

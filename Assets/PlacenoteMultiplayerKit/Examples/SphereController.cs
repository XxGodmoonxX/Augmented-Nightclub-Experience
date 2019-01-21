using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text使うため

public class SphereController : Photon.MonoBehaviour {

  public Transform CameraTransform;
  public GameObject breakOutText;

	private SphereController a, b, c;

	// Use this for initialization
	void Start () {
    CameraTransform = FindObjectOfType<Camera> ().transform;
		breakOutText = GameObject.Find("BreakOutText");

		// Register this object to the current game controller.
    // This is important so that all clients have a reference to this object.
    // GameController.Instance.RegisterSphere (a);
	}
	
	// Update is called once per frame
	void Update () {
		// If this player is not being controlled by the local client
    // then do not update its position. Each client is responsible to update
    // its own player.
		//恐らく自分からは見えないけど相手からは見える、ように、のはず。と思いきや違った。自分から見えてないところじゃないとポジション更新しない的なはず。
    if (!photonView.isMine && PhotonNetwork.connected) {
    	return;
		}

		breakOutText.GetComponent<BreakOutText>().breakOutUpdate();

		// GameController.Instance.RegisterSphere(b);

		// The player should have the same transform as the camera
    // gameObject.transform.position = CameraTransform.position;
    // gameObject.transform.rotation = CameraTransform.rotation;

		//タップしたら1回発動
  	if (0 < Input.touchCount) {
			//タップしたら1回のみ
      if (Input.GetTouch(0).phase == TouchPhase.Began) {
			//画面触っている間
      // if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Moved) {
				// Register this object to the current game controller.
				// This is important so that all clients have a reference to this object.
		    breakOutText.GetComponent<BreakOutText>().breakOutInstantiate();

				// GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				// Material material = new Material(Shader.Find("Diffuse")) {
				// 	// color = new Color(Random.value, Random.value, Random.value)
				// 	color = new Color(0, 0, 200)
				// };
				// sphere.GetComponent<Renderer>().material = material;
				// sphere.transform.position = CameraTransform.transform.TransformPoint(0, 0, 0.5f);
				// float sphereSize = 1.0f;
				// sphere.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);
				// gameObject.AddComponent<Rigidbody>();
				// gameObject.AddComponent<Rigidbody>().AddForce(CameraTransform.TransformDirection(0, 0, 7f), ForceMode.Impulse);

				PhotonNetwork.Instantiate("BlueSphere", Vector3.zero, Quaternion.identity, 0);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCube : MonoBehaviour {

	public GameObject soundObject;
	public GameObject SpherePrefab;

  public Transform CameraTransform;

	int adjustNum;

	// Use this for initialization
	public void Start () {

	}

	// Update is called once per frame
	public void Update () {
		adjustNum = 100; //音量調整用。
		float volume = soundObject.GetComponent<sound>().volume * adjustNum;
		float cubeSize = 0.5f;
		gameObject.transform.position = CameraTransform.TransformPoint(3f, 0, 5f); //カメラの位置に移動して右に1、前に1
		gameObject.GetComponent<Renderer>().material.color = new Color(0, 1.0f, 0, 0.5f);
    gameObject.transform.localScale = new Vector3(cubeSize * volume, cubeSize * volume, cubeSize * volume);
	}
}
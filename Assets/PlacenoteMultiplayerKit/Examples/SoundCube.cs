using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCube : MonoBehaviour {

	public GameObject soundObject;
	public GameObject SpherePrefabRight;
	public GameObject SpherePrefabLeft;

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
		// gameObject.transform.position = CameraTransform.TransformPoint(3f, 0, 5f); //カメラの位置に移動して右に1、前に1

		//右上に
		SpherePrefabRight.transform.position = new Vector3(1f, 3f, 5f);
		SpherePrefabRight.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    SpherePrefabRight.transform.localScale = new Vector3(cubeSize * volume, cubeSize * volume, cubeSize * volume);
		//左上に
		SpherePrefabLeft.transform.position = new Vector3(-1f, 3f, 5f); //カメラの位置に移動して右に1、前に1
		SpherePrefabLeft.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    SpherePrefabLeft.transform.localScale = new Vector3(cubeSize * volume, cubeSize * volume, cubeSize * volume);
	}
}
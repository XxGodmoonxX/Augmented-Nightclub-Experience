using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAnalyser : MonoBehaviour {
	//soundObjectを指定するためのGameObject
	public GameObject soundObject;
	//sound.csから受け取る各周波数の音量を入れる用の配列
	float[] spectrum = new float[256];
	//
	public GameObject Cube;
	public GameObject[] linesRight;
	public GameObject[] linesLeft;

	// Use this for initialization
	void Start () {
		linesRight = new GameObject[256];
		linesLeft = new GameObject[256];
		for (int i = 0; i < soundObject.GetComponent<sound>().spectrumNum.Length; i++) {
			//Cubeをずらして256分表示
			// Vector3 pos = new Vector3 (0.05f * i - 12.8f/2, 0f, 5f); //真ん中から均等に左右に

			Vector3 posRight = new Vector3 (3f - 0.008f * i, 0.5f, 0.05f * i); //真ん中から均等に上下に 右側の波
			linesRight[i] = Instantiate(Cube, posRight, Quaternion.identity) as GameObject;

			Vector3 posLeft = new Vector3 (-3f + 0.008f * i, 0.5f, 0.05f * i); //真ん中から均等に上下に 左側の波
			linesLeft[i] = Instantiate(Cube, posLeft, Quaternion.identity) as GameObject;
		}
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < soundObject.GetComponent<sound>().spectrumNum.Length; i++) {
			spectrum[i] = soundObject.GetComponent<sound>().spectrumNum[i]; //sound.csからspectrumNumをもらってくる
			// Debug.Log(spectrum[100]);

			//各周波数の大きさをCubeの高さに反映
			int adjustNum = 500;
			linesRight[i].transform.localScale = new Vector3(0.05f, 0.05f * spectrum[i] * adjustNum, 0.05f);
			linesLeft[i].transform.localScale = new Vector3(0.05f, 0.05f * spectrum[i] * adjustNum, 0.05f);
		}
	}
}

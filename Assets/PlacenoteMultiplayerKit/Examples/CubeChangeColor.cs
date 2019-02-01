using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChangeColor : MonoBehaviour {

	GameObject[] BreakOutCubeTags; //BreakOutCubeってタグついてるGameobject取得する用

	// Use this for initialization
	void Start () {
		InvokeRepeating("CubeColorChangeWhite", 30f, 30f); //30秒ごとにCubeColorChangeWhite()が働く、つまりまっさらに戻る
		
		// BreakOutCubeTags = GameObject.FindGameObjectsWithTag ("BreakOutCube"); //BreakOutCubeってタグついてるGameobject取得
	}
	
	// Update is called once per frame
	void Update () {
	}

	void CubeColorChangeWhite() {
		gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
}

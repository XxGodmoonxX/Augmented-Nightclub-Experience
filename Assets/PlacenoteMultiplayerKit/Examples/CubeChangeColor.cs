using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChangeColor : MonoBehaviour {

	GameObject[] BreakOutCubeTags; //BreakOutCubeってタグついてるGameobject取得する用

	// Use this for initialization
	void Start () {
		BreakOutCubeTags = GameObject.FindGameObjectsWithTag ("BreakOutCube"); //BreakOutCubeってタグついてるGameobject取得
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CubeColorChangeWhite() {
		// gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
		for (int i = 0; i < 972; i++) {
			BreakOutCubeTags[i].GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
		}
	}
}

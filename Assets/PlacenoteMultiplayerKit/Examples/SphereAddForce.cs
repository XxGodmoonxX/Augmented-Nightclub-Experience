﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAddForce : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
    cam = FindObjectOfType<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0, 0, 2f),ForceMode.Impulse);
	}
}

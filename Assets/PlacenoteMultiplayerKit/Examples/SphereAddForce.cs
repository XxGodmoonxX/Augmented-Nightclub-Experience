using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAddForce : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0, 0, 5f),ForceMode.Impulse);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromCube : MonoBehaviour {

	public GameObject soundObject;
	public GameObject CubePrefab;

	// Use this for initialization
	public void Start () {

	}

	// Update is called once per frame
	public void Update () {
		// soundObject.GetComponent<sound>().ReturnAccess();
		int noteNumber = soundObject.GetComponent<sound>().noteNumberNum;
		Debug.Log(noteNumber);

    if (noteNumber <= 50) {
      GameObject Cube= GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(200, 0, 0)
      };
      Cube.GetComponent<Renderer>().material = material;
			float cubeSize = 0.3f;
      Cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
      Cube.AddComponent<Rigidbody>();
			Cube.transform.position = CubePrefab.transform.TransformPoint(0, 0, -50);
			Cube.GetComponent<Rigidbody>().AddForce(CubePrefab.transform.TransformDirection(2f, 0, 0),ForceMode.Impulse);
    }

    if ((noteNumber > 50) && (noteNumber <= 100)) {
      GameObject Cube= GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(0, 200, 0)
      };
      Cube.GetComponent<Renderer>().material = material;
			float cubeSize = 0.3f;
      Cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
      Cube.AddComponent<Rigidbody>();
			Cube.transform.position = CubePrefab.transform.TransformPoint(0, 0, 0);
			Cube.GetComponent<Rigidbody>().AddForce(CubePrefab.transform.TransformDirection(2f, 0, 0),ForceMode.Impulse);
    }

    if (noteNumber > 100) {
      GameObject Cube= GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Material material = new Material(Shader.Find("Diffuse")) {
      	// color = new Color(Random.value, Random.value, Random.value)
				color = new Color(0, 0, 200)
      };
      Cube.GetComponent<Renderer>().material = material;
			float cubeSize = 0.3f;
      Cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
      Cube.AddComponent<Rigidbody>();
			Cube.transform.position = CubePrefab.transform.TransformPoint(0, 0, 50);
			Cube.GetComponent<Rigidbody>().AddForce(CubePrefab.transform.TransformDirection(2f, 0, 0),ForceMode.Impulse);
    }

	}
}

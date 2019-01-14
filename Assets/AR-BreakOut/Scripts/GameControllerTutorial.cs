using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Placenote
using Placenote;

public class GameControllerTutorial : PlacenotePunMultiplayerBehaviour {

	float x = 0;
	float y = 0;
	float z = 0;

	public Camera cam;

	
	protected override void OnGameStart() {

		PhotonNetwork.Instantiate("Plane", Vector3.zero, Quaternion.identity, 0);
		// PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
		PhotonNetwork.Instantiate("Sphere", Vector3.forward, Quaternion.identity, 0);
		
		if (Input.touchCount > 0 && cam != null) {
    	//CreatePrimitiveで動的にGameObjectであるCubeを生成する
      GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//Cubeに適用するランダムな色を生成する
      Material material = new Material(Shader.Find("Diffuse")) {
        // color = new Color(Random.value, Random.value, Random.value)
				color = new Color(0, 0, 200)
      };
      //ランダムに変化する色をCubeに適用する
      cube.GetComponent<Renderer>().material = material;
      //端末をタップして、ランダムな色のCubeを認識した平面上に投げ出すように追加していく
      //Cubeの大きさも0.2fとして指定している
      cube.transform.position = cam.transform.TransformPoint(0, 0, 0.5f);
			// cube.transform.position = cam.transform.TransformPoint(0.5f, 0, 0);
			float sphereSize = 1.0f;
      cube.transform.localScale = new Vector3(sphereSize, sphereSize, sphereSize);
      //CubeにはRigidbodyを持たせて重力を与えておかないと、床の上には配置されないので注意が必要。Rigidbodyで重力を持たせないとCubeは宙に浮いた状態になる
      cube.AddComponent<Rigidbody>();
			//これでタップしたときに斜め上にキューブ飛んでいく？そして衝突計算
      cube.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(0,1f,2f),ForceMode.Impulse);
			// cube.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(2f, 0, 0),ForceMode.Impulse);
    }
	}

}

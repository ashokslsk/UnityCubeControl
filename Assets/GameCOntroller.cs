using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCOntroller : MonoBehaviour {

	public GameObject[] gameCameras;
	private int gameCameraIndex = 0;

	// Use this for initialization
	void Start () {
		FocusOnCamera (gameCameraIndex);
	}
	
	// Update is called once per frame
	void Update () {
		//Mouse input
		if(Input.GetMouseButtonDown(0)){
			ChangeCamera (1);
		}

		//changing to back camera
		if(Input.GetMouseButtonDown(1)){
			ChangeCamera (-11);
		}
	}

	void FocusOnCamera(int index){
		for (int i = 0; i < gameCameras.Length; i++) {
		
			gameCameras [i].SetActive (i == index);

		}
	}

	void ChangeCamera(int direction){
		gameCameraIndex += direction;

		if (gameCameraIndex >= gameCameras.Length) {
			gameCameraIndex = 0;
		}

		if (gameCameraIndex < 0) {
			gameCameraIndex = gameCameras.Length-1;
		}

		FocusOnCamera (gameCameraIndex);
	}
}

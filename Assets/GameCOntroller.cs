using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCOntroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space")){
			Debug.Log("Jump!");
		}

		if(Input.GetKey("left")){
			Debug.Log("left!");
		}

		if(Input.GetKey("right")){
			Debug.Log("right!");
		}
	}
}

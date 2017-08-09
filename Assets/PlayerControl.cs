using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {


	public float CubeSpeed = 3.5f;
	public float JumpingForce = 10.2f;
	public float RotatingSpeed = 40.2f;
	private bool canJump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("right")){
			transform.RotateAround (transform.position, Vector3.up, RotatingSpeed * Time.deltaTime);
		}

		if(Input.GetKey("left")){
			transform.RotateAround (transform.position, Vector3.up, -RotatingSpeed * Time.deltaTime);
		}

		if(Input.GetKeyDown	("space") && canJump){
			canJump = false;
			GetComponent<Rigidbody> ().AddForce (0,JumpingForce,0); 
		}


		if(Input.GetKey	("up")){
			transform.position += transform.forward * CubeSpeed * Time.deltaTime; 
		}
	}

	void OnCollisionEnter(Collision collision){
	
		if (collision.transform.name == "floor") {

			canJump = true;

		}

	}
}

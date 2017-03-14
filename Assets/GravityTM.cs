using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTM : MonoBehaviour {
	//gravity value
	const float Gravity = 9.81f;
	//gravity magnification(Scale)
	public float gravityScale = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vector = new Vector3 ();

		//set vector by input from smartphones' acceleration censor
		vector.x = Input.acceleration.x;
		vector.y = Input.acceleration.y;
		vector.z = Input.acceleration.z;

		//change gravity
		Physics.gravity = vector.normalized * Gravity * gravityScale;
	}
}

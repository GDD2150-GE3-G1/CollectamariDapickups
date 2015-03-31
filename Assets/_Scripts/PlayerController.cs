﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float forceSpeed = 0;
	
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		forceSpeed = 200 * (gameObject.rigidbody.mass);
		
		rigidbody.AddForce (movement * forceSpeed * Time.deltaTime);
	}
}

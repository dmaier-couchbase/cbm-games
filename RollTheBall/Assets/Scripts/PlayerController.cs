using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	//The ref to the body we want to move
	private Rigidbody rb;


	//Init
	void Start() {
	
		rb = GetComponent<Rigidbody> ();
	
	}
		

	//Update location
	void FixedUpdate() {
	
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveH, 0, moveV);

		rb.AddForce (movement * speed);
	}

}

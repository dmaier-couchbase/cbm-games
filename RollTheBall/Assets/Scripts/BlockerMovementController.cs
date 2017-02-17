using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerMovementController : MonoBehaviour {

	public int steps;
	public int speed;
	public Vector3 startDir;



	private Transform transf;
	private int count;
	private Vector3 dir;



	Vector3 ChangeDir (Vector3 curr) {

		Vector3 result = Vector3.right;

		if (curr == Vector3.right)
			result = Vector3.left;

		return result;

	}

	// Use this for initialization
	void Start () {

		count = 0;
		transf = GetComponent<Transform>();
		dir = startDir;

		if (speed == 0)
			speed = 1;

	}
	
	// Update is called once per frame
	void Update () {

		transf.Translate (dir * Time.smoothDeltaTime * speed);
		count = count + 1;

		Debug.Log ("Count: " + count);

		if (count == steps) {

			count = 0;

			Debug.Log ("Changing direction");
			Debug.Log (dir.ToString());

			dir = ChangeDir (dir);

			Debug.Log (dir.ToString());

		}
	}
}

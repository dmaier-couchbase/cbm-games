using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleController : MonoBehaviour {


	private int score;
	private GameObject scoreObj;


	void Start() {
		
		score = 0;
		scoreObj = GameObject.Find("Score");
		Debug.Log ("Score: " + score);

	}

	void OnTriggerEnter(Collider other) {

		Debug.Log ("Ball has fallen into hole.");

		//Reset Gamer location
		GameObject player = other.gameObject;
		player.transform.position = new Vector3 (0f, 2f, 0f);

		//Increase score
		score = score + 1;
		Debug.Log ("Score: " + score);
		scoreObj.GetComponent<TextMesh> ().text = score.ToString();
	
	}
}

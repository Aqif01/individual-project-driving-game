using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnCollisionEnter2D(Collision2D col){
		//if the enemy car collides with the collider
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (col.gameObject);
		} else if (col.gameObject.tag == "question") {
			Destroy (col.gameObject);
		}


			
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	//takes control of speed of car
	public float carSpeed;
	public float maxPosition = 2.2f;
	//temporary position of the car
	Vector3 position;

	// Use this for initialization
	void Start () {
		//this is the current position of the car
		position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);

		transform.position = position;
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTrack : MonoBehaviour {

	public float speed;
	//move the texture(road)
	Vector2 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//increases the value depending on the time
		offset = new Vector2 (0, Time.time * speed);
		//texture keeps moving downwards over the car
		GetComponent<Renderer>().material.mainTextureOffset = offset;
		
	}
}

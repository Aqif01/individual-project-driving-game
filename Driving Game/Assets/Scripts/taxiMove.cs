using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taxiMove : MonoBehaviour {
	public float speed = 8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//car moves in the y direction
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
		


}

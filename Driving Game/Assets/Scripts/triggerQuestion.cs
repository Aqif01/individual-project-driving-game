﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerQuestion : MonoBehaviour {
	string[] zones = new string[3] { "question1", "question2", "question3"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		int random = Random.Range(0, 3);
		if (coll.gameObject.tag == "question") {
			Application.LoadLevel (zones[random]);
		}
	}

}
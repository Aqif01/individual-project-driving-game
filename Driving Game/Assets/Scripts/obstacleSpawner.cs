using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour {
	public GameObject obstacle;
	public float maxPosition = 2.2f;
	float timer;
	public float delayTimer = 0.5f;

	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 obstaclePos = new Vector3 (Random.Range (-2.2f, 2.2f), transform.position.y, transform.position.z);
			Instantiate (obstacle, obstaclePos, transform.rotation);
			timer = delayTimer;

		}

		
		
	}
}

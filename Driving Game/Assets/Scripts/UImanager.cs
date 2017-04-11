using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {
	public Text scoreText;
	int score;
	bool gameOver;

	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.2f); 
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;


			//if (score >= 50) {
			//	Application.LoadLevel("level2");
			//}
		

	}

	//void OnCollisionEnter2D(Collision2D col){
		//if (col.gameObject.tag == "question") {
			//Application.LoadLevel ("question1");
		//}
	//}


	void scoreUpdate(){
		if (!gameOver) {
			score += 1;
		}
	}

	public void gameOverTrue(){
		gameOver = true;
	}


	public void Play(){
		Application.LoadLevel("level1");
	}

	public void Pause (){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
			
	}


}

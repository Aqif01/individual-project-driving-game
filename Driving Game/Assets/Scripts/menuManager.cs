using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {
	public Text scoreText;
	int score;
	bool gameOver;
	public Button [] buttons;

	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.2f); 
		
	}
		
	void scoreUpdate(){
		if (!gameOver) {
			score += 1;
		}
	}

	public void gameOverTrue(){
		gameOver = true;
		//activating buttons when game is over
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);
		}
	}


	public void Play(){
		SceneManager.LoadScene ("level1");
	}

	public void Pause (){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
			
	}

	public void Replay(){
		SceneManager.LoadScene (Application.loadedLevel);
	}

	public void Menu(){
		SceneManager.LoadScene ("menu");
	}

	public void Exit(){
		Application.Quit ();
	}


}

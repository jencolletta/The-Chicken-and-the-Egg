using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour {

	[SerializeField] private bool isPaused;
	[SerializeField] private GameObject pauseMenuUI;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}
		if (isPaused){
			ActiveMenu();
		}
		else{
			DeactiveMenu();
		}
	}
	public void ActiveMenu(){
		Time.timeScale = 0;
		pauseMenuUI.SetActive(true);
		isPaused = true;
	}
	public void DeactiveMenu(){
		Time.timeScale= 1;
		pauseMenuUI.SetActive(false);
		isPaused = false;
	}
	public void restartgame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void exitgame(){
		Application.Quit();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown4 : MonoBehaviour {

	float currentTime = 0f;
	float startingTime = 100f;
	[SerializeField] Text countdownText;
	[SerializeField] GameObject gameovermenu;
	[SerializeField] GameObject wonmenu;
	[SerializeField] private GameObject pauseButton;
	public playerInventory pInventory;
	public EnemyController enemycontroller;

	// Use this for initialization
	void Start () {
		currentTime=startingTime;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString("0");
		if (currentTime<=10){
			countdownText.color = Color.red;
		}
		if (currentTime < 0 && pInventory.token == 13){
			Won();
		}
		else if (currentTime<0 && pInventory.token!=13){
			GameOver();
		}
		else if (pInventory.token==13){
			Won();
		}
	}
	public void GameOver()
	{
		countdownText.gameObject.SetActive(false);
		pauseButton.gameObject.SetActive(false);
		enemycontroller.MoveSpeed=0;
		gameovermenu.SetActive(true);
	}
	public void Restart(){
		SceneManager.LoadScene(3);
	}
	public void Won(){
		countdownText.gameObject.SetActive(false);
		pauseButton.gameObject.SetActive(false);
		enemycontroller.MoveSpeed=0;
		wonmenu.SetActive(true);
	}
	public void LoadLevelOne(){
    	SceneManager.LoadScene(0);
	}
	public void LoadLevelTwo(){
    	SceneManager.LoadScene(1);
	}
	public void LoadLevelThree(){
    	SceneManager.LoadScene(2);
	}
	public void LoadLevelFour(){
    	SceneManager.LoadScene(3);
	}
	public void LoadLevelFive(){
    	SceneManager.LoadScene(4);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public float myCoolTimer = 120;
	public Text timerText;
	// Use this for initialization
	void Start () {
		timerText=GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		myCoolTimer -= Time.deltaTime;
		int minutes = (int)(myCoolTimer/60);
		int seconds = (int)(myCoolTimer/60)%(60);
		timerText.text = myCoolTimer.ToString("f0");
		
		string timerString = string.Format("{1:00}:{2:00}",minutes,seconds);

		timerText.text = timerString;
	}
}

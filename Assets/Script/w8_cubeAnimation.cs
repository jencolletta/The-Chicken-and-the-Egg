using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w8_cubeAnimation : MonoBehaviour {
	public int speed = 100;
	/* public GameObject particle;
	public AudioSource soundEffect;
	// Use this for initialization
	void Start () {
		soundEffect = GetComponent<AudioSource>();
		particle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		soundEffect.Play();
		particle.SetActive(true);
	}*/
	//void OnTriggerStay(){
	void Update(){
		transform.Rotate(new Vector3(0,Time.deltaTime * speed,0));
	}
	/* void OnTriggerExit(){
		soundEffect.Pause();
		particle.SetActive(false);
	}*/
}

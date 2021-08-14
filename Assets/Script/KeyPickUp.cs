using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPickUp: MonoBehaviour {
	//public AudioSource audiosource;
	//public AudioClip otherClip;
	void Start()
     {
		 //audiosource = GetComponent<AudioSource>();
		 //audiosource.clip=otherClip;
     }
	public playerInventory pInventory;
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name=="player"){
			pInventory.token++;
			//audiosource.Play();
			Destroy (gameObject);
		}
	}
}
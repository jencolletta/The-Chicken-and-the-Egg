using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenDisplay : MonoBehaviour {
	public playerInventory pInventory;
	[SerializeField] public Text tokenText;
	// Use this for initialization
	void Start () {
		
	}
	void Update(){
		tokenText.text=pInventory.token.ToString();
	}
	
}

using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class EnemyController : MonoBehaviour
 {
 
     public Transform Player;
     public int MoveSpeed = 5;
     int MaxDist = 3;
     int MinDist = 0;
     [SerializeField] Text countdownText;
	 [SerializeField] GameObject gameovermenu;
     [SerializeField] private GameObject pauseButton;

 
     void Start()
     {
     }
 
     void Update()
     {

       
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
         }
     }
     void OnTriggerEnter(Collider collider)
     {
		 if (collider.gameObject.name=="player"){
             GameOver();
		     }
	 }

    public void GameOver()
     {
		 countdownText.gameObject.SetActive(false);
		 pauseButton.gameObject.SetActive(false);
		 MoveSpeed=0;
		 gameovermenu.SetActive(true);
	 }

 }
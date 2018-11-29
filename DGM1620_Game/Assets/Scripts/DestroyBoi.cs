using UnityEngine;
using System.Collections;

public class DestroyBoi : MonoBehaviour {

	public LevelManager LevelManager;

//	public HealthManager HealthManager;


	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "boi"){
	 LevelManager.RespawnPlayer();
			// HealthManager.LifeToAdd(-1);
		}
	}
}

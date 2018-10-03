using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//point penalty on death
	public int PointPenaltyOnDeath;

	//store gravity value
	private float GravityStore;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}
	
	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
		//hide player
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		//gravity reset
		GravityStore = player.GetComponent<Rigidbody2D>().GravityScale;
		player.GetComponent<Rigidbody2D>().GravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
	}
	// Update is called once per frame
	void Update () {
		
	}
}

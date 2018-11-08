using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	public GameObject Player2;

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
		//Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}
	
	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);

		//hide player

		//Player.enabled = false;
		Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;

		//gravity reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);

		//Debug Message
		Debug.Log ("Player Respawn");

		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);

		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;

		//Match Players Transform Position
		Player.transform.position = CurrentCheckPoint.transform.position;

		//Show Player
		
		//Player.enabled = true;
		Player2.SetActive(true);
		Player.GetComponent<Renderer>().enabled = true;

		//Spawn Player
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}

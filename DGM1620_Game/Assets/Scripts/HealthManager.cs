using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public static int Health;
	
	public static bool Invincible;
	
	public static int Counter;

	Text HealthText;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 1;

		Invincible = false;

		Counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health > 3)
			Health = 3;
			HealthText.text = " " + Health;
		if (Counter > 0)
			Counter -= 1;
		if (Counter == 0)
			Invincible = false;
	}

	public static void AddHealth (int HealthToAdd) {
		Health += HealthToAdd;
	}

	public static void ResetHealth(){
		Health = 1;
	}

	public static int GetHealth(){
		return Health;
	}

	public static void DecrementHealth(){
		if (Invincible == false){
			Health -= 1;
			Counter = 30;
		}
		if (Counter >= 0)
			Invincible = true;
	}
}

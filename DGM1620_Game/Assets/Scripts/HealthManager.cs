using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public static int Health;
	
	Text HealthText;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health > 3)
			Health = 3;
		HealthText.text = " " + Health;

	}

	public static void AddHealth (int HealthToAdd) {
		Health += HealthToAdd;
	}

	public static void ResetHealth(){
		Health = 1;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;
	
	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0)
			Ammo = 0;
		if (Ammo > 5)
			Ammo = 5;
		
		AmmoText.text = " " + Ammo;


	}

	public static void AddAmmo (int AmmoToAdd) {
		Ammo += AmmoToAdd;
	}

	public static void ResetAmmo(){
		Ammo = 5;
	}

	public static int GetAmmoCount(){
		return Ammo;
	}
}

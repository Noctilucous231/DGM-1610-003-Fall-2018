﻿using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;

	// Use this for initialization
	void Start () {
		//Projectile = GameObject.Find("Projectile");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
	}
}
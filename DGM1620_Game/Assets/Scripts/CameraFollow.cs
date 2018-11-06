using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove Boi;

	public bool isFollowing;

	//Camera position offset
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		Boi = FindObjectOfType<CharacterMove>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(Boi.transform.position.x + xOffset, Boi.transform.position.y + yOffset, transform.position.z);
		}		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	//5 for each loops / for loops
	//5 arrays

	public int[] Eggs = new int[12];
	public string[] Loot = new string[10];
	public string[] Jedi = new string[12];

	// Use this for initialization
	void Start () {
		
		Loot = new string[10];
		Loot[0] = "money";
		Loot[1] = "potions";
		Loot[2] = "gem";
		Loot[3] = "weapon";
		Loot[4] = "arrows";
		Loot[5] = "bombs";
		Loot[6] = "boots";
		Loot[7] = "chest armor";
		Loot[8] = "pant";
		Loot[9] = "mega powerup";

		foreach(string item in Loot){
			print("Monster dropped " + item);
		}

		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;

		print(Eggs[8]);

		Jedi = new string[5];

		Jedi[0] = "Obi wan kenobi";
		Jedi[1] = "Luke";
		Jedi[2] = "Jar Jar";
		Jedi[3] = "jawa";
		Jedi[4] = "Anakin";

		foreach(string item in Jedi){
			print("jedi master " + item);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

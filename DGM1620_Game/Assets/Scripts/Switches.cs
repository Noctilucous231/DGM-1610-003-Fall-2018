using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

//	public int Num;
//	public string Name;

	//My Switches
	
//	public string Light;
	public  string color;
	public int Candy;
	public bool Jump; 
	public string NPC;
//	public float Flying;
	
	// Use this for initialization
	void Start () {

// 	switch(Flying){
// 		case 3.5:
// 			print("woah, you're soaring!");
// 		break;

// 		case 2.1:
// 			print("you call that " + Flying);
// 		break;

// 		case 1.3:
// 			print("yikes, you must have crashed. ");
// 		break;

// 		default:
// 			print("Guess you can't fly, huh?");
// 		break;
// 	}


	switch(Jump){
		case true:
			print("I'm Jumpiiiiing " + Jump);
		break;

		case false:
			print("i'm jumping " + Jump);
		break;
	}	




		switch(NPC){
			case "Happy":
				print("hello!");
			break;

			case "Mean":
				print("I don't like adventurers");
			break;

			case "Relaxed":
				print("You seem cool.");
			break;

			default:
				print("I AM ERROR.");
			break;
	}

		switch(Candy){
			case 1:
				print("you have " + Candy + " candy!!!");
			break;

			case 2:
				print("you have " + Candy + " candies!!!");
			break;

			case 3:
				print("you have " + Candy + " candies!!!");
			break;

			case 4:
				print("you have " + Candy + " candies!!!");
			break;

			case 5:
				print("you have " + Candy + " candies!!!");
			break;

			default:
				print("zero, zip, nada");
			break;
	}
		switch(color){
			case "Blue":
				print("I like " + color);
			break;

			case "Red":
				print("I think " + color + " is okay.");
			break;

			case "Yellow":
				print(color + " is way too bright");
			break;

			case "Black":
				print(color + " is like my soul");
			break;

			default:
				print("EWWWW");
			break;
	}


//		switch(Num){

//			case 1:
//				print("you picked" + Num );
//			break;

//			case 3:
//				print("you picked" + Num );
//		break;

//			case 6:
//				print("you picked" + Num );
//			break;

//			case 10:
//				print("you picked" + Num );
//			break;

//			default:
//				print("I don't understand" + Num);
//			break;
//		}

//	switch(Name){
//		case "Jason":
//			print("Welcome to camp crystal lake " + Name + " - Love Mother");
//		break;

//		case "Micheal":
//			print("welcome to haddonfield " + Name);
//		break;

//		case "Freddie":
//			print("Welcome to Elm Street " + Name);
//		break;

//		case "Leatherface":
//			print("The stars and stripes are big at night... Deep in the heart of Texas " + Name);
//		break;

//		default:
//			print("Game Over");
//		break;
//	}





	





//	switch(Light){
//		case "dim":
//			print("I can hardly see it's very " + Light);
//		break;

//		case "bright":
//			print("oh good it's way too " + Light);
//		break;
		
//		case "regular":
//			print("ah the lighting here is " + Light + " that's a relief.");
//		break;
		
//		case "dark":
//			print("AHHHH I HATE THE " + Light + " HEEEEEELP");
//		break;
		
//		default:
//			print("hmmm very odd i don't even know what to think of this");
//		break;
//	}
}



	

	
	
	// Update is called once per frame
	void Update () {
		
	}
}

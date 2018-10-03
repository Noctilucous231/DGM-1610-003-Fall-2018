using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	//declare three variables
	public int Variable1;
	public int Variable2;
	int Total;

	void Start(){
		CalcAdd();
	}

	public void CalcAdd(){
	
		AddVariables(Variable1,Variable2);
	}

	public void AddVariables(int One, int Two){

		Total = One + Two;

			print(Total);
	}
}
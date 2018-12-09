using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public int HealthToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<CharacterMove> () == null)
			return;

		HealthManager.AddHealth (HealthToAdd);

		Destroy (gameObject);
	}
}
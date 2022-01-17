using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour 
{
	// Colliders and triggers
	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log("Ouch!");
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Package") 
		{
			Debug.Log ("Package picked up");
		}
		//Debug.Log("What was that?!");

	}
}
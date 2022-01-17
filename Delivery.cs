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
		// if it's packagee
		if (other.tag == "Package" && !hasPackage) 
		{
			Debug.Log ("Package picked up");
			hasPackage = true;
			Destroy (other.gameObject, destroyDelay);
		}
		// if it's Customer
		if (other.tag == "Customer" && hasPackage) 
		{
			Debug.Log ("Package delivered");
			hasPackage = false;
		}

	}
}
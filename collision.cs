using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour 
{
	// Colliders and triggers
	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log("Ouch!");
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("What was that?!");
	}
}
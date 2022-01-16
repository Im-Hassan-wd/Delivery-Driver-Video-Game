using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour 
{
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log("Ouch!");
	}
	
	void OnTriggerEnter2D(Collision2D other) {
		Debug.Log("What was that?!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
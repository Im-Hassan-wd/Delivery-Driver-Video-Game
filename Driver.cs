using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour 
{
    // defining speed,
    [SerializeField] float steerSpeed = 0.3f;
	[SerializeField] float moveSpeed = 0.03f;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		float steerAmount = Input.GetAxis ("Horizontal");
		transform.Rotate(0, 0, steerAmount);
		transform.Translate(0, moveSpeed, 0);
	}
}
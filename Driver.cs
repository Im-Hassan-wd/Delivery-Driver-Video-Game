using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour 
{
    // defining speed,
    float steerSpeed = 0.1f;
	float moveSpeed = 0.01f;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
	}
}
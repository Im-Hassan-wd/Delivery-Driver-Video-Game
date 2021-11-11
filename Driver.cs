using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour 
{
    // defining speed,
    [SerializeField] int steerSpeed = 3;
	[SerializeField] float moveSpeed = 0.05f;
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		float steerAmount = Input.GetAxis ("Horizontal") * steerSpeed * Time.deltaTime;
		float moveAmount = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
		transform.Rotate(0, 0, -steerAmount);
		transform.Translate(0, moveAmount, 0);
	}
}
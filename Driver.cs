using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour 
{
    // defining speed,
    [SerializeField] float steerSpeed = 50f;
	[SerializeField] float moveSpeed = 1f;
	[SerializeField] float slowSpeed = 5f;
	[SerializeField] float boostSpeed = 130f;
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

	void OnCollisionEnter2D(Collision2D other)
	{
		moveSpeed = slowSpeed;	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boost") 
		{
			moveSpeed = boostSpeed;
		}
	}
}
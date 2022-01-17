using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
	[SerializeField] GameObject thingToFollow;
	// the camera position should be the sa,e as the gameObject (car);

	void Update () {
		transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
	}
}
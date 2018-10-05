using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	GameObject ball;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("Bowling Ball");
		offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z <= 1829f)
		{
			transform.position = ball.transform.position + offset;
		}
	}
}

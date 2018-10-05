using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody rigidBody;
	private AudioSource audiosSource;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		audiosSource = GetComponent<AudioSource>();
		rigidBody.velocity = new Vector3(0, 0, 1700);
		audiosSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanController : MonoBehaviour {

	public Vector3 com;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass = com;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

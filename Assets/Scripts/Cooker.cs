using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooker : MonoBehaviour {

	public Collider cook_col;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider trigger) {
		trigger.SendMessage("Cook", trigger, SendMessageOptions.DontRequireReceiver);
	}
}

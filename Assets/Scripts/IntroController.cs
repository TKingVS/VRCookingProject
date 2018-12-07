using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		OVRInput.Update();

		if (OVRInput.Get(OVRInput.Button.One)) {
			SceneManager.LoadScene("main_scene");
		}
	}

	void FixedUpdate() {
		OVRInput.FixedUpdate();
	}
}

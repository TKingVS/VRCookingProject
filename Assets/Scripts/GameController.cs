using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Cookable[] food;
	public Text winText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		OVRInput.Update();

		bool allCooked = true;
		foreach (Cookable item in food) {
			if (!item.isCooked()) {
				allCooked = false;
			}
		}
		if (allCooked) {
			Debug.Log("win");
			winText.gameObject.SetActive(true);
		}

		if (OVRInput.Get(OVRInput.Button.One)) {
			SceneManager.LoadScene("main_scene");
		}
	}

	void FixedUpdate () {
		OVRInput.FixedUpdate();
	}
}

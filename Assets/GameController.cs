using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Cookable[] food;
	public Text winText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		bool allCooked = true;
		foreach (Cookable item in food) {
			if (!item.isCooked()) {
				allCooked = false;
			}
		}
		if (allCooked) {
			winText.enabled = true;
		}
	}
}

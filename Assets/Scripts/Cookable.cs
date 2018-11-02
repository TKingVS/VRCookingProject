using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookable : MonoBehaviour {

	public Material mat_top, mat_bot;
	public Collider col_top, col_bot;
	public Color cooked_color = new Color(0.848f, 0.472f, 0, 1);

	private float cook_timer_top, cook_timer_bot;
	private float cook_time;

	// Use this for initialization
	void Start() {
		cook_timer_top = cook_timer_bot = 0.0f;
		cook_time = 10.0f;
	}
	
	// Update is called once per frame
	void Update() {

	}

	void OnDestroy() {
		mat_top.color = Color.white;
		mat_bot.color = Color.white;
	}

	void Cook(Collider trigger) {
		if (trigger == col_top && cook_timer_top <= cook_time) {
			cook_timer_top += Time.fixedDeltaTime;
			mat_top.color = Vector4.Lerp(Color.white, cooked_color, cook_timer_top / cook_time);
		}
		if (trigger == col_bot && cook_timer_bot <= cook_time) {
			cook_timer_bot += Time.fixedDeltaTime;
			mat_bot.color = Vector4.Lerp(Color.white, cooked_color, cook_timer_bot / cook_time);
		}
	}
}

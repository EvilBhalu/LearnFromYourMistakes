﻿using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider hit) {
		Application.LoadLevel("Scene2");
	}
}
﻿using UnityEngine;
using System.Collections;

public class LevelAdvance : MonoBehaviour {
	public string level;
	void OnTriggerEnter2D (Collider2D other)
	{


			Application.LoadLevel (level);


	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

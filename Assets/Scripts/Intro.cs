using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	public string level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.)) 
		{
			Application.LoadLevel (level);
		}
	}
}

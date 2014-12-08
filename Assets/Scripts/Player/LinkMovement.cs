using UnityEngine;
using System.Collections;

public class LinkMovement : Entity {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) 
		{
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)) 
		{
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
		}	
	}

}
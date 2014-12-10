using UnityEngine;
using System.Collections;

public class MarioBox : MonoBehaviour {

	public GUITexture textbox; // <-- Assign your GUITexture to this.
	
	void OnTriggerEnter2D(Collider2D other) {
		textbox.enabled = true;
	}
	
	void OnTriggerExit2D(Collider2D other) {
		textbox.enabled = false;
	}
}

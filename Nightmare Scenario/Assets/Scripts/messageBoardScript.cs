using UnityEngine;
using System.Collections;

public class messageBoardScript : MonoBehaviour {

	public GUIText heading;
	public GUIText message1;
	public GUIText message2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnTriggerCollider2D(Collider2D other)
	{
		if (other.tag == "Player") {
			heading.text = "How to not die:";
			message1.text = "Controls:Jump: Space Button Movement: a and d Pause: p button";
			message2.text= "Objectives:- Head to the red door- don't touch anything- seriously, don't touch anything";
		}
	}
}

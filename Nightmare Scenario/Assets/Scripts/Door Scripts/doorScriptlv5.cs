﻿using UnityEngine;
using System.Collections;

public class doorScriptlv5 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (9);
		}
	}
	void Update(){
	}
}
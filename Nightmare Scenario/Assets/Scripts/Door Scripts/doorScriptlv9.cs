﻿using UnityEngine;
using System.Collections;

public class doorScriptlv9 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (8);
			}
		}
		void Update(){
		}
}

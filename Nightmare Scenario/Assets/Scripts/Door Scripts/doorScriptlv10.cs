﻿using UnityEngine;
using System.Collections;

public class doorScriptlv10 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (9);
			}
		}
		void Update(){
		}
}
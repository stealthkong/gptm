﻿using UnityEngine;
using System.Collections;

public class doorScriptlv19 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (18);
			}
		}
		void Update(){
		}
}
using UnityEngine;
using System.Collections;

public class godSpikeKill : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (26);
			}
		}
		void Update(){
		}
	}

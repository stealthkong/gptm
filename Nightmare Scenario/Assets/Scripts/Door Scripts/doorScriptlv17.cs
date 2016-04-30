using UnityEngine;
using System.Collections;

public class doorScriptlv17 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (16);
			}
		}
		void Update(){
		}
}

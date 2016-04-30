using UnityEngine;
using System.Collections;

public class doorScriptlv11 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (10);
			}
		}
		void Update(){
		}
}

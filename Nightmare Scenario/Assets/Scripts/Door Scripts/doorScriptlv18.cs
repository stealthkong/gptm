using UnityEngine;
using System.Collections;

public class doorScriptlv18 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (20);
			}
		}
		void Update(){
		}
}

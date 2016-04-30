using UnityEngine;
using System.Collections;

public class doorScriptlv12 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (14);
			}
		}
		void Update(){
		}
}


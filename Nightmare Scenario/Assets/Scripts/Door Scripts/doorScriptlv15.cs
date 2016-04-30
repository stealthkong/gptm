using UnityEngine;
using System.Collections;

public class doorScriptlv15 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (17);
			}
		}
		void Update(){
		}
}

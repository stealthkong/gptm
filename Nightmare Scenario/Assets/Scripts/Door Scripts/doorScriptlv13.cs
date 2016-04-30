using UnityEngine;
using System.Collections;

public class doorScriptlv13 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (15);
			}
		}
		void Update(){
		}
}

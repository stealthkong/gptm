using UnityEngine;
using System.Collections;

public class GodDoorScriptlv15 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (38);
			}
		}
		void Update(){
		}
}

using UnityEngine;
using System.Collections;

public class GodDoorScriptlv9 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (32);
			}
		}
		void Update(){
		}
}

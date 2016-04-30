using UnityEngine;
using System.Collections;

public class GodDoorScriptlv19 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (42);
			}
		}
		void Update(){
		}
}
using UnityEngine;
using System.Collections;

public class GodDoorScriptlv17 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (40);
			}
		}
		void Update(){
		}
}

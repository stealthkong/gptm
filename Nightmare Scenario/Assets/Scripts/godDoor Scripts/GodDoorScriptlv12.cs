using UnityEngine;
using System.Collections;

public class GodDoorScriptlv12 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (35);
			}
		}
		void Update(){
		}
}


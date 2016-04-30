using UnityEngine;
using System.Collections;

public class GodDoorScriptlv14 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (37);
			}
		}
		void Update(){
		}
}

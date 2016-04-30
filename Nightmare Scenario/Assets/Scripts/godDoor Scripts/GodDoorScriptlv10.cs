using UnityEngine;
using System.Collections;

public class GodDoorScriptlv10 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (33);
			}
		}
		void Update(){
		}
}
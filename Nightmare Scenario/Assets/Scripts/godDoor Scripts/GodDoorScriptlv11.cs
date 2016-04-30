using UnityEngine;
using System.Collections;

public class GodDoorScriptlv11 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (34);
			}
		}
		void Update(){
		}
}

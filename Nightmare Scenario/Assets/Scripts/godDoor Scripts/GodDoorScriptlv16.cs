using UnityEngine;
using System.Collections;

public class GodDoorScriptlv16 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (39);
			}
		}
		void Update(){
		}
}
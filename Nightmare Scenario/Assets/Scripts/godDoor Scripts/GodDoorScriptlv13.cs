using UnityEngine;
using System.Collections;

public class GodDoorScriptlv13 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (36);
			}
		}
		void Update(){
		}
}

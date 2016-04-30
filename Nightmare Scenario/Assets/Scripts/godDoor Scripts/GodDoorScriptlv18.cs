using UnityEngine;
using System.Collections;

public class GodDoorScriptlv18 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (41);
			}
		}
		void Update(){
		}
}

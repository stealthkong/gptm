using UnityEngine;
using System.Collections;

public class doorScriptlv14 : MonoBehaviour {

	public class doorScriptlv6 : MonoBehaviour {
		
		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player") {
				Application.LoadLevel (13);
			}
		}
		void Update(){
		}
	}
}
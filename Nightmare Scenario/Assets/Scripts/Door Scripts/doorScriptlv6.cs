using UnityEngine;
using System.Collections;

public class doorScriptlv6 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (7);
		}
	}
	void Update(){
	}
}

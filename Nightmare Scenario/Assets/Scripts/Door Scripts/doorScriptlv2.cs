using UnityEngine;
using System.Collections;

public class doorScriptlv2 : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (0);
		}
	}
	void Update(){
	}
}
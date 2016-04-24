using UnityEngine;
using System.Collections;

public class doorScriptlv3 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (4);
		}
	}
	void Update(){
	}
}

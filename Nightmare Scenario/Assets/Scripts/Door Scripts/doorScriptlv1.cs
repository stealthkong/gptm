using UnityEngine;
using System.Collections;

public class doorScriptlv1 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (2);
		}
	}
	void Update(){
	}
}

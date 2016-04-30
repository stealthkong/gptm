using UnityEngine;
using System.Collections;

public class GodDoorScriptlv5 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (30);
		}
	}
	void Update(){
	}
}
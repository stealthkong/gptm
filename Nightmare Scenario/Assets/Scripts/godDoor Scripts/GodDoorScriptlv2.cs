using UnityEngine;
using System.Collections;

public class GodDoorScriptlv2 : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (27);
		}
	}
	void Update(){
	}
}
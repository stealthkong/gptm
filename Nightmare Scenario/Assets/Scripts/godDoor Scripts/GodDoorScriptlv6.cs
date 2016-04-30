using UnityEngine;
using System.Collections;

public class GodDoorScriptlv6 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (31);
		}
	}
	void Update(){
	}
}

using UnityEngine;
using System.Collections;

public class GodDoorScriptlv20 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (43);
		}
	}
	void Update(){
	}
}

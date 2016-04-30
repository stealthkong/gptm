using UnityEngine;
using System.Collections;

public class GodDoorScriptlv3 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (28);
		}
	}
	void Update(){
	}
}

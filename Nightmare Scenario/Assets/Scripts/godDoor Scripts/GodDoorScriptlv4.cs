using UnityEngine;
using System.Collections;

public class GodDoorScriptlv4 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (29);
		}
	}
	void Update(){
	}
}
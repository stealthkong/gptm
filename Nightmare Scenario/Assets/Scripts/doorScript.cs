using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

	void OnTriggerEnter(Collider2D other)
	{
		if(Input.GetKeyDown (KeyCode.W))
		Application.LoadLevel (2);
	}
	void Update(){
	}
}

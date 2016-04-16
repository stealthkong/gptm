using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(Input.GetKeyDown (KeyCode.W))
		Application.LoadLevel (2);
	}
	void Update(){
	}
}

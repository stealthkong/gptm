using UnityEngine;
using System.Collections;

public class spikeKill : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Application.LoadLevel (5);
		}
	}
	void Update(){
	}
}

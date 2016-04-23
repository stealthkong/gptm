using UnityEngine;
using System.Collections;

public class holdPlayerPlat : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		col.transform.parent = gameObject.transform;
	}
	
	void OnTriggerExit2D(Collider2D col){
		col.transform.parent = null;
	}
}

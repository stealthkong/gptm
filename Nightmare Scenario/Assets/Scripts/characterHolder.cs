using UnityEngine;
using System.Collections;

public class characterHolder : MonoBehaviour {

	void OnCollisionEnter2D(Collider2D col){
		col.transform.parent = gameObject.transform;
	}
	
	void OnCollisionExit2D(Collider2D col){
		col.transform.parent = null;
	}
}

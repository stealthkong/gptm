using UnityEngine;
using System.Collections;

public class playerKill : MonoBehaviour {

	//public void OnCollisionEnter(Collision collision)
	public void onCollisonEnter(Collider2D collision)
	{
		if(collision.gameObject.tag == "player" )
		{
			Destroy(collision.gameObject);
		}
	}

}

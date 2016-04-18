using UnityEngine;
using System.Collections;

public class playerKill : MonoBehaviour {

	public int deathCount = 0;

	public GUIText livesBox;

	//public void OnCollisionEnter(Collision collision)
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "sawBlade" )
		{
			Destroy(this);
		}
	}

	void updateLives()
	{
		livesBox.text = "Lives Lost: " + deathCount;
	}

}

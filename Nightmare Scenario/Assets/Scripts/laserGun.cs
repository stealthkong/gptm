using UnityEngine;
using System.Collections;

public class laserGun : MonoBehaviour {

	public GameObject laserBullet;
	public GameObject player;


	// Use this for initialization
	void Start () {
		Invoke ("fireLaser", 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void fireLaser()
	{
		player = GameObject.Find ("player");

		if (player != null) {
			GameObject blast =(GameObject)Instantiate (laserBullet);

			blast.transform.position = transform.position;

			Vector2 direction = player.transform.position - blast.transform.position;

			//blast.GetComponent<laserBullet>().SetDirection(direction);
		}
	}
}

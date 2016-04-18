using UnityEngine;
using System.Collections;

public class laserScript : MonoBehaviour {

	public Rigidbody2D laserBlast;
	public Transform laserBoom;
	public Transform laserPos1;
	public Transform laserPos2;
	public Vector3 projectile;
	public string currentState;
	public float speed = 10f;
	public float resetTime;
	
	// Use this for initialization
	void Start () {
		laserFire ();
	}

	
	// Update is called once per frame
	void Update () {
			Rigidbody inp = Instantiate(laserBlast, transform.position, transform.rotation) as Rigidbody;
			//inp.velocity = transform.TransformDirection(new Vector3(0,0,speed));
		laserBoom.position = Vector3.Lerp (laserBoom.position, projectile, speed * Time.deltaTime);

	}

	void laserFire()
	{
		if (currentState == "Moving to laserPos1") {
			currentState = "Moving to laserPos2";
			projectile = laserPos2.position;
		} else if (currentState == "") {
			currentState = "Moving to laserPos2";
			currentState = "Moving to laserPos1";
		}
		Invoke ("laserFire", resetTime);
	}
}
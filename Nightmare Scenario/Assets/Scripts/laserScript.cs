using UnityEngine;
using System.Collections;

public class laserScript : MonoBehaviour {

	public Rigidbody2D laserBlast;
	public float speed = 10f;
	
	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
			Rigidbody inp = Instantiate(laserBlast, transform.position, transform.rotation) as Rigidbody;
			inp.velocity = transform.TransformDirection(new Vector3(0,0,speed));

	}
}
﻿using UnityEngine;
using System.Collections;

public class godScript : MonoBehaviour {

	public float maxSpeed = 7f;
	bool facingRight = true;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 300f;
	public int deathCount = 0;
	public GUIText livesBox;
	public bool playerDead;
	public GameObject restartText;
	public GameObject pressKey;
	//public int level = 1;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (playerDead == true) {

			if(Input.GetKeyDown (KeyCode.R))
				Application.LoadLevel (Application.loadedLevel);
			return;

		}

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D> ().velocity.y);



		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs(move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	
	}

	void Update()
	{

		livesBox.text = "Lives Lost: " + deathCount;

		if (grounded && Input.GetKeyDown(KeyCode.Space)) 
		{
			anim.SetBool ("Ground", false);
			GetComponent<Rigidbody2D> ().AddForce(new Vector2(0, jumpForce)); 
		}

		if(Input.GetKeyDown (KeyCode.R))
			Application.LoadLevel (Application.loadedLevel);
		return;
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
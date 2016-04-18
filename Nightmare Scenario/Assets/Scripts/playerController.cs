using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour 
{

	//Movement
	public float speed = 3f;
	public float jump;
	public float move;
	float moveVelocity;
	bool facingRight = true;

	Animator anim;

	//Grounded Vars
	bool grounded = true;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate () 
	{

		//Jumping
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
		{
			if(grounded)
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
			}
		}

		moveVelocity = 0;

		// Movement animation
		move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed", Mathf.Abs (move));

		//Left Right Movement
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
		{
			moveVelocity = -speed;
		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
		{
			moveVelocity = speed;
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);


	}
	//Check if Grounded
	void OnTriggerEnter2D()
	{
		grounded = true;
	}
	void OnTriggerExit2D()
	{
		grounded = false;
	}

	//public void Flip()
	//{
	//	facingRight = !facingRight;
	//	Vector3 theScale = Transform.localScale;
	//	theScale.x *= -1;
	//	Transform.localScale = theScale;
	//}
}
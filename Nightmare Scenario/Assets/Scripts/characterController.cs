using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour
{
	public float maxSpeed = 10f; // Variable for the fastes spped the player can travel
	bool facingRight = true;	// Determines which way the player is facing
	
	public Animator anim;	// References the players animator component

	float groundRadius = 0.2f;	// Radius to determine if the player is grounded
	public LayerMask whatIsGround;	//Mask that determines what is ground to the character
	public float jumpForce = 700f;	// The force added when jumping
	public float crouchSpeed = .36f;	// maxSpeed applied to crouchiing
	
	public bool grounded = false;	// Variable for whether the player is grounded or not
	public Transform groundCheck;	// Determines whether the player is grounded
	public Transform ceilingCheck;	// Determines the spot where the 'ceiling' of the level is
	
	bool doubleJump = false; // Double jump component
	
	public void Awake()
	{
		groundCheck = transform.Find ("GroundCheck");
		ceilingCheck = transform.Find ("CeilingCheck");
		anim = GetComponent<Animator>();
	}
	
	void FixedUpdate()
	{
			grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
			anim.SetBool("Ground", grounded);
			
			// Sets doubleJump variable for later use
			if(grounded)
				doubleJump = false;
			
			anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
		
			// component to prevent player from controlling character midair. I'm leaving this in here
			// incase this is something we would want to implement, but for a game like what we
			// are making, this might help the player with precision controls

			//if(!grounded) return;
			
			float move = Input.GetAxis("Horizontal");
			
			anim.SetFloat("Speed", Mathf.Abs(move));
			
		GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
			
			if(move > 0 &&!facingRight)
				Flip();
			else if(move < 0 && facingRight)
				Flip();
	}

	void Update()
	{
		if((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

			if(!doubleJump && !grounded)
				doubleJump = true;
		}
	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
}
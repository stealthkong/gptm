using UnityEngine;
using System.Collections;

public class playerController : MonoBehavior
{
	public float maxSpeed = 10f;
	bool facingRight = true;
	
	Animator anim;
	
	bool grounded = false;
	public Transfomr groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	
	bool doubleJump = false; // Double jump component
	
	void start()
	{
		anim = GetComponent<Animator>();
	}
	
	void FixedUpdate()
	{
			grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
			anim.SetBool("Ground", grounded);
			
			// Sets doubleJump variable for later use
			if(grounded)
				doubleJump = false;
			
			anim.SetFloat("vSpeed", rigibody2D.velocity.y);
		
			// component to prevent player from controlling character midair. I'm leaving this in here
			// incase this is something we would want to implement, but for a game like what we
			// are making, this might help the player with precision controls
			//if(!grounded) return;
			
			float move = Input.GetAxis("Horizontal");
			
			anim.SetFloat("Speed", Mathf.Abs(move));
			
			rigibody2D.Velocity = new Vector2(move * maxSpeed, rigibody2D.velocity.y);
			
			if(move > 0 &&! facingRight)
				Flip();
			else if(move < 0 && facingRight)
				Flip();
	}
	
	void Update()
	{
		if((grounded || !doubleJump) && Input.GetKeyDown)
		{
			anim.SetBool("Ground", false);
			rigibody2D.AddForce(new, Vector2(0, jumpForce));
			
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
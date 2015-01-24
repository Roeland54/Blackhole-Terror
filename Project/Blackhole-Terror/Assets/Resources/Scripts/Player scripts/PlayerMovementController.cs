using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	
	public float maxSpeed = 10f;
	
	bool grounded = true;
    bool canMove = true;
    public Transform[] wallChecks = new Transform[4];
    public Transform groundCheck;
	float groundRadius = 0.05f;
	public LayerMask whatIsGround; 
	public float jumpForce = 200f;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate ()
	{
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        bool iHittedTheWall = false;

        foreach (var wallCheck in wallChecks)
        {
            iHittedTheWall = iHittedTheWall || Physics2D.OverlapCircle(wallCheck.position, groundRadius, whatIsGround);
        }

		float move = Input.GetAxis ("Horizontal");
        if (grounded || (rigidbody2D.velocity.x < 1 && !iHittedTheWall))
        {
            rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
        }
	}

	void Update ()
	{
		if (grounded && Input.GetButtonDown ("Jump")) 
		{	

			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}

	}

}

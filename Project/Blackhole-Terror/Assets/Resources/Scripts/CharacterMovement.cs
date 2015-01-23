using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	
	public float Speed = 0f;
	public float MaxJumpTime = 2f;
	public float JumpForce;
	private float move = 0f;
	private float JumpTime = 0f;
	private bool CanJump;
	
	
	void Start () {
		JumpTime  = MaxJumpTime;
	}
	
	
	void Update ()
	{
		if (!CanJump)
			JumpTime  -= Time.deltaTime;
		if (JumpTime <= 0)
		{
			CanJump = true;
			JumpTime  = MaxJumpTime;
		}
	}
	
	void FixedUpdate () {
		move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (move * Speed, rigidbody2D.velocity.y);
		if (Input.GetButtonDown("Jump") && CanJump)
		{
			rigidbody2D.AddForce (new Vector2 (rigidbody2D.velocity.x,JumpForce));
			CanJump = false;
			JumpTime  = MaxJumpTime;
		}
	}
}

using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour 
{

	public float maxSpeed = 10f;
	
	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate ()
	{
		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

	}
	

}

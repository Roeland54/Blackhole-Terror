using UnityEngine;
using System.Collections;

public class BlackholeGravityBorder : MonoBehaviour {

	private Vector3 otherPosition;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		MoveToBlackhole moveToblackHole = other.gameObject.AddComponent<MoveToBlackhole> ();
		moveToblackHole.blackHolePosition = this.gameObject.transform.position;
		moveToblackHole.speed = speed;

	}
}

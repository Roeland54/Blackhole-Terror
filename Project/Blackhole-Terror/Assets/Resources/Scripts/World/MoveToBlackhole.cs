using UnityEngine;
using System.Collections;

public class MoveToBlackhole : MonoBehaviour {

	public Vector3 blackHolePosition;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, blackHolePosition, speed);
	}
}

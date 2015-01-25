using UnityEngine;
using System.Collections;

public class BlackholeGrow : MonoBehaviour {

	public float speed = 10f;
	private Vector3 currentScale;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		currentScale = this.gameObject.transform.localScale;
		this.gameObject.transform.localScale = Vector3.Lerp (currentScale, new Vector3(100,100), speed * Time.deltaTime);

	}
}

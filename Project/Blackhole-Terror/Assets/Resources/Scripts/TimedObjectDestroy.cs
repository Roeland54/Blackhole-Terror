using UnityEngine;
using System.Collections;

public class TimedObjectDestroy : MonoBehaviour {

	public float destroyDelay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, destroyDelay);
	}
}

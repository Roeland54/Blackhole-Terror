using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {
	public int objectHP = 20;
	public float currentHP = 20;
	public float destroyDelay = 3;

	// Use this for initialization
	void Start () {
		currentHP = objectHP;	
	}
	
	// Update is called once per frame
	void Update () {
//		currentHP = currentHP - Time.deltaTime;
		if (currentHP < 1) {
						Destroy ();
				}	
	}

	void Destroy(){
		rigidbody2D.isKinematic = false;
		//Destroy (gameObject, destroyDelay);
		}
}

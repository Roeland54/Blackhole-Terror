using UnityEngine;
using System.Collections;

public class PlayerTeleporter : MonoBehaviour {

	public float teleportDelay = 0.1F;
	private float passiveClock;
	public Transform directionA;
	//public Transform directionB;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		passiveClock = passiveClock + Time.deltaTime;

	
	}

	void OnTriggerEnter2D(Collider2D other){
		print ("Collission detected!");
		if (other.gameObject.tag == "Player") {
			print("Player teleported!");
			if (passiveClock > teleportDelay) {
				other.transform.position = directionA.position;
					passiveClock = 0.0f;
				}
			}
		}

}

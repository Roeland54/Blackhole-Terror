using UnityEngine;
using System.Collections;

public class TimedExplosion : MonoBehaviour {
	private bool countdown;
	public float timer = 10.0F;
	public GameObject explosionPrefab;
	public GameObject dangerPrefab;
	public float destroyDelay;

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
		if (countdown) {
			timer = timer - Time.deltaTime;
				}
		if(timer < 0){
			Explode();
		}
	
	}

	void OnThrown(){
		countdown = true;
		dangerPrefab.gameObject.SetActive (true);
			//Instantiate(dangerPrefab, new Vector3(transform.position.x, transform.position.y, -0.4F), transform.rotation);
		}

	void Explode(){
		Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, -0.4F), transform.rotation);
		Destroy (gameObject, destroyDelay);
	}
}

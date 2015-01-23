using UnityEngine;
using System.Collections;

public class DamageReceiver : MonoBehaviour {

	public int hp = 1;
	public float destroyDelay = 0.5F;
	public GameObject explosionPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Damage")
		{
			if (hp < 2)
			{
				Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, -0.4F), transform.rotation);
				Destroy (gameObject, destroyDelay);
			}
			else
			{
			hp = hp - 1;
			}
		}
	}
}
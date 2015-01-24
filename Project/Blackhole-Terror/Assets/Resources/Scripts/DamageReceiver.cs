using UnityEngine;
using System.Collections;

public class DamageReceiver : MonoBehaviour {

	public int hp = 1;
	public float destroyDelay = 0.5F;
	public GameObject explosionPrefab;

	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "Damage")
		{
			if (hp < 2)
			{
				rigidbody2D.AddForce(Vector2.up * 10);
				Die ();
			}
			else
			{
			hp = hp - 1;
			}
		}
	}

	void Die() {
		Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, -0.4F), transform.rotation);
		Destroy (gameObject, destroyDelay);
	}
}
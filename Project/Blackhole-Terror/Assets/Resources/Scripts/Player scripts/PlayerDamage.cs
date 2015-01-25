using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

	public int hp = 1;
	public float destroyDelay = 0.5F;
	public float forceAdder = 10.0F;
	public GameObject explosionPrefab;

	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "Damage")
		{
			if (hp < 2)
			{
				rigidbody2D.AddForce(Vector2.up * forceAdder);
				Die ();
			}
			else
			{
			hp = hp - 1;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "DamageAll")
		{
			if (hp < 2)
			{
				rigidbody2D.AddForce(Vector2.up * forceAdder);
				Die ();
			}
			else
			{
				hp = hp - 1;
			}
		}
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 11) {
            Die();
        }
    }

	void Die() {
		Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, -5.0F), transform.rotation);
        Application.LoadLevel("GameOver");
	}
}
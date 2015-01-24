using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    public float PickupDistance = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pickup"))
        {
            Debug.Log("Pickup is hit");

            float feetY = renderer.bounds.max.y;
            var colliders = Physics2D.OverlapAreaAll(new Vector2(transform.position.x - PickupDistance, feetY - PickupDistance), new Vector2(transform.position.x - PickupDistance, feetY + PickupDistance));
            Debug.Log(string.Format("Found {0} ", colliders.Length));
            
            foreach (var collider in colliders)
            {
                var pickupItem = collider.gameObject.GetComponent<PickupAble>();
                if (pickupItem)
                {
                    DestroyImmediate(collider.gameObject);
                }
            }

        }
	}
}

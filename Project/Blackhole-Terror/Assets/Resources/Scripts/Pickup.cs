using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    public float PickupDistance = .1f;
    public LayerMask PickupMask;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pickup"))
        {
            Debug.Log("Pickup is hit");

            var colliders = Physics2D.OverlapCircleAll(renderer.bounds.center, PickupDistance, PickupMask);
            Debug.Log(string.Format("Found {0} ", colliders.Length));
            
            foreach (var collider in colliders)
            {
                Debug.Log(collider.gameObject.name);
                DestroyImmediate(collider.gameObject);
            }

        }
	}
}

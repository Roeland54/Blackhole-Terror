using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Inventory))]
public class Pickup : MonoBehaviour {

    public float PickupDistance = .1f;
    public LayerMask PickupMask;
    private Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = gameObject.GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pickup") && inventory && !inventory.IsFull)
        {
            var collider = Physics2D.OverlapCircle(renderer.bounds.center, PickupDistance, PickupMask);
            if (collider)
            {
                Debug.Log(collider.gameObject.name);
                collider.gameObject.SetActive(false);
                inventory.Add(collider.gameObject);
            }
        }
	}
}

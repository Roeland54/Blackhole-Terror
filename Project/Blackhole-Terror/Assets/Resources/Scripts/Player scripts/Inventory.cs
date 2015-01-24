using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour {

    public float HugeForce = 10f;
    public float DropForce = 1f;

    public bool IsFull = false;
    public Canvas HudDisplay;
    private GameObject[] inventory = new GameObject[4];
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            FireObject(HudDisplay.GetComponent<InventoryToggleBehavior>().SelectedIndex, HugeForce);
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            FireObject(HudDisplay.GetComponent<InventoryToggleBehavior>().SelectedIndex, DropForce);            
        }
	}

    

    public void Add(GameObject item) {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (!inventory[i])
            {
                inventory[i] = item;
                var renderer = item.GetComponent<SpriteRenderer>();
                if (!renderer)
	            {
		             renderer = item.transform.FindChild("Sprite").GetComponent<SpriteRenderer>();
	            }

                HudDisplay.GetComponent<InventoryToggleBehavior>().inventoryButtons[i].GetComponent<ToggleItemScript>().Item = renderer.sprite;
                break;
            }
        }
    }

    public void RemoveAt(int index) {
        HudDisplay.GetComponent<InventoryToggleBehavior>().inventoryButtons[index].GetComponent<ToggleItemScript>().Item = null;
        inventory[index] = null;
    }

    private void FireObject(int index, float force) {

        if (inventory[index])
        {
            var firepoint = transform.FindChild("Aiming Arrow/FirePoint");
            inventory[index].transform.position = firepoint.position;
            inventory[index].transform.rotation = firepoint.rotation;

            inventory[index].SetActive(true);
            inventory[index].rigidbody2D.AddRelativeForce(new Vector2(force, 0), ForceMode2D.Impulse);

            RemoveAt(index);
        }
        
    }
}

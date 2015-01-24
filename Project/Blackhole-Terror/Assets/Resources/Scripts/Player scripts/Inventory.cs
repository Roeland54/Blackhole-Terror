using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour {

    public float HugeForce = 100f;
    public float DropForce = 10;

    public bool IsFull = false;
    public Canvas HudDisplay;
    private GameObject[] inventory = new GameObject[4];
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            FireObject(HudDisplay.GetComponent<InventoryToggleBehavior>().SelectedIndex, HugeForce);
        }
        else if (Input.GetButtonDown("Fire1"))
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
                HudDisplay.GetComponent<InventoryToggleBehavior>().inventoryButtons[i].GetComponent<ToggleItemScript>().Item = item.GetComponent<SpriteRenderer>().sprite;
                break;
            }
        }
    }

    public void RemoveAt(int index) {
        HudDisplay.GetComponent<InventoryToggleBehavior>().inventoryButtons[index].GetComponent<ToggleItemScript>().Item = null;

    }

    private void FireObject(int index, float force) {

        if (inventory[index])
        {
            float angle = gameObject.GetComponent<AimingController>().aimingAngle;
            inventory[index].transform.position = transform.position;
            inventory[index].SetActive(true);
            inventory[index].rigidbody2D.AddForce(new Vector2(Mathf.Cos(angle) * force, Mathf.Sin(angle) * force));
        }
        
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryToggleBehavior : MonoBehaviour {

    public Toggle[] inventoryButtons = new Toggle[4];
    private int selector = 0;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetButtonDown("Next"))
        {
            inventoryButtons[Mod(++selector)].isOn = true;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0 || Input.GetButtonDown("Previous"))
        {
            inventoryButtons[Mod(--selector)].isOn = true;

        }
	}

    public int SelectedIndex { get { return Mod(selector); } }

    private int Mod(int value) {
        while (value < 0)
        {
            value += inventoryButtons.Length;
        }
        return value % inventoryButtons.Length;
    }
}

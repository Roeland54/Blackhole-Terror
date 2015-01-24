using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleItemScript : MonoBehaviour {

    public float Speed = 2.5f;
    public Sprite Item;
    public Image Image;

	// Use this for initialization
	void Start () {
        Image.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
        if (Item)
        {
            Image.color = Color.Lerp(Image.color, Color.white, Speed * Time.deltaTime);
            Image.sprite = Item;
        }
        else
        {
            Image.color = Color.Lerp(Image.color, Color.clear, Speed * Time.deltaTime);
        }
	}
}

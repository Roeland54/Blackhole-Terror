using UnityEngine;
using System.Collections;

public class Wincondition : MonoBehaviour 
{
	public bool magenta;
	public bool yellow;
	public bool green;
	public bool blue;
	public bool purple;
	public string Nextlevel;

	void Update ()
	{
		if(magenta==true && yellow==true && green==true && blue==true && purple==true)
		{
			Application.LoadLevel(Nextlevel);
		}
	}
	void OnTriggerEnter (Collider c)
	{
		if (c.collider.tag == "Magenta")
		{
			magenta = true;
		}
		if (c.collider.tag == "Yellow")
		{
			yellow = true;
		}
		if (c.collider.tag == "Green")
		{
			green = true;
		}
		if (c.collider.tag == "Blue")
		{
			blue = true;
		}
		if (c.collider.tag == "Purple")
		{
			purple = true;
		}
	}
}

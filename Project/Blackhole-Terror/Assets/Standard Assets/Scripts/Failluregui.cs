using UnityEngine;
using System.Collections;

public class Failluregui : MonoBehaviour {

	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(45,45,110,50), "Faillure");
		
		
		// Make the second button.
		if(GUI.Button(new Rect(60,70,80,20), "Retry")) 
		{
			Application.LoadLevel("Initialisationscene");
		}
	}
}
using UnityEngine;
using System.Collections;

public class StartupGUIscript : MonoBehaviour 
{		
		void OnGUI () 
	{
		if(GUI.Button(new Rect(60,70,80,20), "Scenario 1")) 
		{
			Application.LoadLevel("Scenario1");
		}
		if(GUI.Button(new Rect(60,100,80,20), "Scenario 2")) 
		{
			Application.LoadLevel("Scenario2");
		}
		if(GUI.Button(new Rect(60,130,80,20), "Scenario 3")) 
		{
			Application.LoadLevel("Scenario3");
		}
		if(GUI.Button(new Rect(60,160,80,20), "Scenario 4")) 
		{
			Application.LoadLevel("Scenario4");
		}
	}
}

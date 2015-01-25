using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void restart() {
        Application.LoadLevel("Gameplay Linked");
    }

    public void Exit() {
        Application.Quit();
    }
}

﻿using UnityEngine;
using System.Collections;

public class BlackholeDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Character") {
						Application.LoadLevel ("GameOver");	
				} else {
						Destroy (other.gameObject);
				}
	}
}

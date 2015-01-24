﻿using UnityEngine;
using System.Collections;

public class AimingController : MonoBehaviour {

	public Vector3 aimPoint;
	public Transform aimingArrow;
	public float aimingAngle;
	public float rotationSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		aimingArrow.position = this.transform.position;
		aimPoint = Input.mousePosition;
		aimPoint = Camera.main.ScreenToWorldPoint (aimPoint);
		aimPoint = aimPoint - this.transform.position;

		aimingAngle = (Mathf.Atan2(aimPoint.y, aimPoint.x) * (180 / Mathf.PI));

		//aimPoint.y = aimPoint.y * 25;
//
//		if (aimPoint.x < 0) 
//		{
//			aimPoint.y += 180;	
//		}
//		else if (aimPoint.y < 0)
//		{
//			aimPoint.y += 360;
//		}

		if (aimingAngle < 0) 
		{
			aimingAngle += 360;
		}

		aimPoint = new Vector3 (0, 0, Mathf.LerpAngle(aimingArrow.eulerAngles.z, aimingAngle, rotationSpeed*Time.deltaTime));
		aimingArrow.eulerAngles = aimPoint;
	}
}
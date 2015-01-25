using UnityEngine;
using System.Collections;

public class AimingController : MonoBehaviour {

	public Vector3 aimPoint;
	public Transform aimingArrow;
	public float aimingAngle = 0f;
	public float rotationSpeed = 10f;

    private bool gamepadMode = false;

	// Use this for initialization
	void Start () {
        gamepadMode = Input.GetJoystickNames().Length > 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gamepadMode)
        {
            aimingArrow.position = this.transform.position;
            aimPoint = Input.mousePosition;
            aimPoint = Camera.main.ScreenToWorldPoint(aimPoint);
            aimPoint = aimPoint - this.transform.position;

            aimingAngle = (Mathf.Atan2(aimPoint.y, aimPoint.x) * (180 / Mathf.PI));
        }
        else
        {
            aimingAngle += Input.GetAxis("Vertical") * rotationSpeed / 5;   
        }
		
		aimPoint = new Vector3 (0, 0, Mathf.LerpAngle(aimingArrow.eulerAngles.z, aimingAngle, rotationSpeed*Time.deltaTime));
		aimingArrow.eulerAngles = aimPoint;
	}
}

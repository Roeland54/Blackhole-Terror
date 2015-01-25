using UnityEngine;
using System.Collections;

public class rotatorscript : MonoBehaviour {

	public int Rotatepower;

	void Update () 
	{
		transform.Rotate(Vector3.down * Time.deltaTime * Rotatepower, Space.World);
	}
}

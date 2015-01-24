using UnityEngine;
using System.Collections;

public class SizeBouncer : MonoBehaviour {

	public float duration = 1.0F;
	public float minIntensity = 1.0f;
	public float maxIntensity = 2.0f;
	public float sizeX;
	public float sizeZ;
	
	void Update() {

		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude = Mathf.Cos(phi) * minIntensity + maxIntensity;
		gameObject.transform.localScale = new Vector3(sizeX, amplitude, sizeZ);
		//light.intensity = amplitude;
	}
}
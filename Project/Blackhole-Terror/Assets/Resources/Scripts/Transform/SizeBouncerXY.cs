using UnityEngine;
using System.Collections;

public class SizeBouncerXY : MonoBehaviour {

	public float duration = 1.0F;
	public float minIntensity = 1.0f;
	public float maxIntensity = 2.0f;
	public float sizeZ;
	
	void Update() {

		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude = Mathf.Cos(phi) * minIntensity + maxIntensity;
		gameObject.transform.localScale = new Vector3(amplitude, amplitude, sizeZ);
		//light.intensity = amplitude;
	}
}
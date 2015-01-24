using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PlayerCamera : MonoBehaviour {

    public float MaxDistance = 5f;
    public float Speed = 15f;

    public Transform Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Player)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, Player.position, Speed * Time.fixedDeltaTime);
            newPosition.z = transform.position.z;
            transform.position = newPosition;
        }
	}
}

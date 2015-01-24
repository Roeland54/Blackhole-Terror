using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {
    public float speed = 10f;
    public float Delay = 5f;

	
	// Update is called once per frame
	void Update () {
        if (Delay > 0)
        {
            Delay -= Time.deltaTime;
        }
        else
        {
            Physics2D.gravity = Vector2.Lerp(Physics2D.gravity, new Vector2(0f, 9.81f), speed * Time.deltaTime);
        }
	}
}

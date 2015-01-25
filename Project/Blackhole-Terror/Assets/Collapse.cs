using UnityEngine;
using System.Collections;

public class Collapse : MonoBehaviour {

    private bool isActive = false;
    public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        {
            var currentScale = this.gameObject.transform.localScale;
            this.gameObject.transform.localScale = Vector3.Lerp(currentScale, new Vector3(0, 0), speed * Time.deltaTime);
        }

        if (this.gameObject.transform.localScale.x < 0.5)
        {
            Destroy(gameObject);
        }
	}

    public void Activate() { 
        isActive = true;
    }
}

using UnityEngine;
using System.Collections;

public class SceneBuildScript : MonoBehaviour {

	public GameObject[] levels;
	public GameObject endFloor;
    public int NumberOffSubLevels = 2;

    private Vector3 previousSize;
    private GameObject previousIn;
    private float previousY = 0f;


	// Use this for initialization
	void Start () {
        previousSize = CalculateTotalSize(gameObject, false);
        previousIn = transform.FindChild("TeleportIN").gameObject;

        CreateRoom(endFloor);
	
	}
	


	// Update is called once per frame
	void Update () {
	
	}

    private void CreateRoom(GameObject obj) {
        GameObject instance = (GameObject)Instantiate(obj, new Vector2(-100, -100), Quaternion.identity);
        var newSize = CalculateTotalSize(instance);
        float newY = previousY + (newSize.y / 2) + (previousSize.y / 2);
        Vector2 position = new Vector2(0, newY);


        instance.transform.position = position;
    }

    private Vector3 CalculateTotalSize(GameObject obj, bool substract = true) {
        Bounds b = new Bounds();
        Transform[] children = obj.GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            var renderer = child.gameObject.renderer;
            if (renderer)
            {
                if (b != null)
                {
                    b = renderer.bounds;
                }
                else
                {
                    b.Encapsulate(renderer.bounds);
                }
            }
        }

        if (substract)
	    {
		    return new Vector3(b.size.x - 100, b.size.y - 100);
	    }else
	    {
            return b.size;
	    }
        
    }
}

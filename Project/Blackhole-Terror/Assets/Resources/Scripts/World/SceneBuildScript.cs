using UnityEngine;
using System.Collections;

public class SceneBuildScript : MonoBehaviour {

	public GameObject[] levels;
	public GameObject endFloor;
	private int levelcount;

	// Use this for initialization
	void Start () {
		levelcount = levels.Length;
		DetectTopPosition (this.gameObject);

	
	}

	void DetectTopPosition(GameObject level)
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

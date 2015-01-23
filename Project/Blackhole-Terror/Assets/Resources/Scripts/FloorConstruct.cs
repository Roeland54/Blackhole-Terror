using UnityEngine;
using System.Collections;

public class FloorConstruct : MonoBehaviour {
    public Sprite Left;
    public Sprite Right;
    public Sprite[] Between;

    public int NumberOffPieces;


	// Use this for initialization
	void Start () {
        float tileSize = Left.bounds.size.x;
        float totalsize = tileSize * (NumberOffPieces + 2);
        float startX = -(totalsize / 2);

        var left = GameObject.Instantiate(Left, new Vector2(startX, 0), Quaternion.identity);

	}
	
}

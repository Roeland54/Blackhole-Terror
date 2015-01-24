using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class FloorConstruct : MonoBehaviour {
    public Sprite Left;
    public Sprite Right;
    public Sprite[] Between;

    public int NumberOffPieces = 1;
    private int LastNumber = 0;

    void Start() {
    }

	// Use this for initialization
	void Update () {
        if (NumberOffPieces != LastNumber)
        {
            Cleanup();

            float tileSize = Left.bounds.size.x;
            float totalsize = tileSize * (NumberOffPieces + 2);
            float startX = -(totalsize / 2);

            InstantiateFloorPiece(startX, Left);

            for (int i = 0; i < NumberOffPieces; i++)
            {
                startX += tileSize;
                InstantiateFloorPiece(startX, Between[Random.Range(0, Between.Length - 1)]);
            }
            startX += tileSize;
            InstantiateFloorPiece(startX, Right);

            LastNumber = NumberOffPieces;

            var colider = gameObject.AddComponent<BoxCollider2D>();
            colider.size = new Vector2(totalsize, tileSize);
            colider.center = new Vector2(-tileSize / 2, 0);
        }
        
	}

    private void Cleanup() {
        try
        {
            DestroyImmediate(gameObject.GetComponent<BoxCollider2D>());
        }
        catch { }

        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }

    }

    private void InstantiateFloorPiece(float x, Sprite sprite) {
        var section = new GameObject();
        section.transform.parent = this.transform;
        section.transform.localPosition = new Vector2(x, 0);
        var sp = section.AddComponent<SpriteRenderer>();
        sp.sprite = sprite;
    }
	
}

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
    private List<GameObject> tiles;

    void Start() {
        tiles = new List<GameObject>();
    }

	// Use this for initialization
	void Update () {
        if (NumberOffPieces != LastNumber)
        {
            try
            {
                DestroyImmediate(gameObject.GetComponent<BoxCollider2D>());
            }
            catch { }

            tiles.ForEach(DestroyImmediate);
            tiles.Clear();

            float tileSize = Left.bounds.size.x;
            float totalsize = tileSize * (NumberOffPieces + 2);
            float startX = -(totalsize / 2);

            InstantiateFloorPiece(startX, Left);

            for (int i = 0; i < NumberOffPieces; i++)
            {
                startX += tileSize;
                InstantiateFloorPiece(startX, Between[Random.Range(0, Between.Length)]);
            }
            startX += tileSize;
            InstantiateFloorPiece(startX, Right);

            LastNumber = NumberOffPieces;

            var colider = gameObject.AddComponent<BoxCollider2D>();
            colider.size = new Vector2(totalsize, tileSize);
            colider.center = new Vector2(-tileSize / 2, 0);
        }
        
	}

    private void InstantiateFloorPiece(float x, Sprite sprite) {
        var section = new GameObject();
        section.transform.parent = this.transform;
        section.transform.localPosition = new Vector2(x, 0);
        var sp = section.AddComponent<SpriteRenderer>();
        sp.sprite = sprite;

        tiles.Add(section);
    }
	
}

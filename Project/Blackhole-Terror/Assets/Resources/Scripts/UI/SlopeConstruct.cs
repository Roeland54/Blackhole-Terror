using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SlopeConstruct : MonoBehaviour {

    public Sprite Filler;
    public Sprite First;
    public Sprite Last;
    public Sprite[] Between;

    public int NumberOffPieces = 1;
    public float Angle = 45f;
    private int LastNumber = 0;
    private float LastAngle = 0f;

    void Start() {
    }

    // Use this for initialization
    void Update() {
        if (NumberOffPieces != LastNumber || LastAngle != Angle)
        {
            Cleanup();

            float tileSize = First.bounds.size.x;
            float totalsize = tileSize * (NumberOffPieces + 2);

            float shiftX = Mathf.Cos(Angle * Mathf.Deg2Rad) * tileSize;
            float shiftY = Mathf.Sin(Angle * Mathf.Deg2Rad) * tileSize;

            float startX = -((NumberOffPieces + 2) / 2) * shiftX;
            float startY = -((NumberOffPieces + 2) / 2) * shiftY;

            InstantiateFloorPiece(startX, startY, First);

            for (int i = 0; i < NumberOffPieces; i++)
            {
                startX += shiftX;
                startY += shiftY;
                InstantiateFloorPiece(startX, startY, Between[Random.Range(0, Between.Length - 1)]);
            }

            startX += shiftX;
            startY += shiftY;

            InstantiateFloorPiece(startX, startY, Last);

            LastNumber = NumberOffPieces;
            LastAngle = Angle;

            
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

    private void InstantiateFloorPiece(float x, float y, Sprite sprite) {
        var section = new GameObject();
        section.transform.parent = this.transform;
        section.transform.localPosition = new Vector2(x, y);
        section.transform.rotation = transform.rotation;
        var sp = section.AddComponent<SpriteRenderer>();
        sp.sprite = sprite;

        var colider = section.AddComponent<BoxCollider2D>();
    
    }
}

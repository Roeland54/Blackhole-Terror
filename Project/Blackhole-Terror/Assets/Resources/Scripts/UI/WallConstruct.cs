using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class WallConstruct : MonoBehaviour {
	public Sprite Bottom;
	public Sprite Top;
	public Sprite[] Between;
	
	public int NumberOffPieces = 1;
	private int LastNumber = 0;

	// Use this for initialization
	void Update () {
		if (NumberOffPieces != LastNumber)
		{
			Cleanup();
			
			float tileSize = Bottom.bounds.size.x;
			float totalsize = tileSize * (NumberOffPieces + 2);
			float startY = -(totalsize / 2);
			
			InstantiateWallPiece(startY, Bottom);
			
			for (int i = 0; i < NumberOffPieces; i++)
			{
				startY += tileSize;
				InstantiateWallPiece(startY, Between[Random.Range(0, Between.Length - 1)]);
			}
			startY += tileSize;
			InstantiateWallPiece(startY, Top);
			
			LastNumber = NumberOffPieces;
			
			var colider = gameObject.AddComponent<BoxCollider2D>();
			colider.size = new Vector2(tileSize, totalsize);
			colider.center = new Vector2(0, -tileSize / 2);
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
	
	private void InstantiateWallPiece(float y, Sprite sprite) {
		var section = new GameObject();
		section.transform.parent = this.transform;
		section.transform.localPosition = new Vector2(0, y);
		var sp = section.AddComponent<SpriteRenderer>();
		sp.sprite = sprite;
	}
	
}


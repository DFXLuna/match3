using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
	public Transform tile;
	private List<Transform> tiles;
	// For testing
	public int testRows = 0;
	public int testCols = 0;
	public Transform testJewel;
	private List<Transform> testJewels;

	void Start () {
		tiles = new List<Transform>();
		createGrid( testRows, testCols );
		testJewels = new List<Transform>();
		// jewel test
		Vector3 pos = tiles[0].position;
		pos.y += .51f;
		testJewels.Add( Object.Instantiate( testJewel, pos, testJewel.rotation ) );
	}

	void Update () {
		
	}

	void createGrid( int r, int c ){
		Vector3 pos;
		pos.y = 0;
		// Figure out where to position the grid tiles.
		float distX = r / 2;
		float distY = c / 2;
		if( r % 2 == 0 ){ distX -= .5f; }
		if( c % 2 == 0 ){ distY -= .5f; }
		for( int i = 0; i < r; i++ ){
			for( int j = 0; j < c; j++ ){
				pos.x = i + - distX;
				pos.z = j + - distY;
				tiles.Add( Object.Instantiate( tile, pos, Quaternion.identity ) );
			}
		}
	}
}

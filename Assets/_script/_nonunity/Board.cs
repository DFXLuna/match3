using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board {
	private Transform tile;
	private List<Transform> tiles;

	public Board( int rows, int cols, Transform tile ) {
		this.tile = tile;
		tiles = new List<Transform>();
		createGrid( rows, cols );
	}

	private void createGrid( int r, int c ){
		Vector3 pos;
		pos.y = 0;
		// Figure out where to position the grid tiles.
		float distX = r / 2;
		float distY = c / 2;
		if( r % 2 == 0 ){ distX -= .5f; }
		if( c % 2 == 0 ){ distY -= .5f; }
		// Populate the board
		for( int i = 0; i < r; i++ ){
			for( int j = 0; j < c; j++ ){
				pos.x = i + - distX;
				pos.z = j + - distY;
				tiles.Add( Object.Instantiate( tile, pos, Quaternion.identity ) );
			}
		}
	}
}

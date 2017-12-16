using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelManager : MonoBehaviour {
	public Transform testJewel;
	private List<Transform> testJewels;
	void Start () {
		testJewels = new List<Transform>();
		testJewels.Add( Object.Instantiate( testJewel, pos, testJewel.rotation ) );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

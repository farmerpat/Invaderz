using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFleetController : MonoBehaviour {
	public int level = 1;
	private int fleetRows;
	private int maxShotsOnScreen;
	// the fleet should be a 2d array
	// of enemy prefabs

	void Start () {
		this.fleetRows = level;
		this.maxShotsOnScreen = 4 * level;
		this.GenerateFleet ();
		this.SpawnFleet ();
		
	}
	
	void Update () {
		
	}

	private void GenerateFleet () {
		// build the 2d FleetCollection array

	}

	private void SpawnFleet () {
		// draw the 2d FleetCollection array to screen

	}
}

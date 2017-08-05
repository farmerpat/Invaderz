using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFleetController : MonoBehaviour {
	public int level = 1;
	private int fleetWidth = 4;
	private int fleetRows;
	private int maxShotsOnScreen;
	private List<List<GameObject>> fleetCollection;

	void Start () {
		this.fleetCollection = new List<List<GameObject>> ();
		this.fleetRows = level;
		this.maxShotsOnScreen = 4 * level;
		this.GenerateFleet ();
		this.SpawnFleet ();

	}

	void Update () { }

	private void GenerateFleet () {
		for (int i = 1; i < level + 1; ++i) {
			List<GameObject> subList = new List<GameObject> ();
			for (int j = 0; j < fleetWidth; j++) {

				string prefabName = "Enemy" + i.ToString ();
				GameObject enemy = (GameObject)Instantiate(Resources.Load(prefabName));
				// hide them until we correctly set their positions
				// can try doing this by getting the screen dimensions and mathing
				enemy.GetComponent<Renderer>().enabled = false;

				subList.Add (enemy);

			}

			fleetCollection.Add (subList);
		}
	}

	private void SpawnFleet () {
		// draw the 2d FleetCollection array to screen

	}
}

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] attackerPrefabArray;					//Define the GameObject Array to store all the type of attackers
	private GameObject attackerParent;							//Define the GameObject to store all the instatiated attacker inside it
	public float spawnRate = 3f;								//Define the spawn rate
	private float lastSpawnTime;								//Define the last spawn time

	// Use this for initialization
	void Start () {
		//Check whether the attacker parent object exist or not, if not, create a new one
		attackerParent = GameObject.Find ("Attackers");
		if (attackerParent == null) {
			attackerParent = new GameObject("Attackers");
		}
	}
	
	// Update is called once per frame
	void Update () {
		float intervalTime = Time.time - lastSpawnTime;			//Calculate the interval time between last spawn time and the next spawn request

		//Check the interval time lager than the spawn rate and update the last spawn time
		if (intervalTime >= spawnRate) {				
			Spawn ();
			lastSpawnTime = Time.time;							//Update the last spawn time
		}
	}

	void Spawn() {
		int attackerChosen;										//Define the type of attcaker would be instantiated
		attackerChosen = Random.Range (0, 2);
		Debug.Log (attackerChosen);
		GameObject newAttacker = Instantiate (attackerPrefabArray [attackerChosen], transform.position, Quaternion.identity) as GameObject;
		newAttacker.transform.parent = attackerParent.transform;			//Store the instantiated attacker in the attacker parent
	}
}

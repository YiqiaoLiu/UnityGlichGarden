using UnityEngine;
using System.Collections;

public class AttackerSpawner : MonoBehaviour {

	public GameObject[] attackerPrefabArray;					//Define the GameObject Array to store all the type of attackers
	private float lastSpawnTime;								//Define the last spawn time

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//For each type of the attacker, just check the instantiate requirement, if meet, instantiate the specific attacker
		foreach(GameObject currentAttacker in attackerPrefabArray){
			if (isTimeToSpawn (currentAttacker)) {
				Spawn (currentAttacker);
			}
		}
	}

	//Spawn fucntion to instantiate the specific attacker
	void Spawn(GameObject attackerSpawn) {
		GameObject newAttacker = Instantiate (attackerSpawn) as GameObject;		//Instantiate the specific attacker
		newAttacker.transform.position = transform.position;					//Define the attacker instantiate position
		newAttacker.transform.parent = transform;								//Define the attacker gameobject's location
	}

	//isTimeToSpawn function to check in this frame, shall we need to instantiate a new attacker
	bool isTimeToSpawn(GameObject attackerSpawn){
		AttackerController thisAttacer = attackerSpawn.GetComponent <AttackerController> ();		//Get the AttackerController of the specific instantiate attacker
		float spawnRate = thisAttacer.spawnRate;													//Get the spawnRate of the specific attacker
		float spawnPerSecond = 1 / spawnRate;														//Calculate how many of this type of accakcer will be instantiated per second

		float temp = spawnPerSecond * Time.deltaTime / 5;
		float check = Random.value;
		if (check < temp) {
			return true;
		} else {
			return false;
		}
	}
}

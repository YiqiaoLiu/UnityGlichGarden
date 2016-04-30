using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public GameObject defenderParent;						//Store all instantiate defender inside this GameObject

	// Use this for initialization
	void Start () {
		//Check whether the parent Gameobject exsit or not. If not, create a new GameObject
		defenderParent = GameObject.Find ("Defenders");
		if (defenderParent == null) {
			defenderParent = new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//The click event
	void OnMouseDown() {
		GameObject defender = ButtonController.selectedDefender;												//Define the type of defender need to be instantiated 
		GameObject newDefender = Instantiate (defender, spawnPosition (), Quaternion.identity) as GameObject;	//Instantiate the defender
		newDefender.transform.parent = defenderParent.transform;												//Store the defender inside the parent GameObject
	}

	//Calculate the position the user click to instantiate the defender
	Vector2 spawnPosition(){
		Camera camera = GameObject.FindObjectOfType<Camera>();								//Get the camera componenet
		Vector3 calcuPos;																	//This variable used to store the screenToWorldPoint's result
		Vector2 mousePos = Input.mousePosition;												//Get the mouse position
		Vector2 spawnPos;																	//This variable used to store the actual position to spawn denfender
		calcuPos = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0));		//use ScreenToWorldPoint to calculate the world point
		spawnPos = new Vector2 (calcuPos.x, calcuPos.y);									//Set the spawnPos value
		return snapToGrid(spawnPos);														//To make the final position is integer
	}

	//To ensure that the final position is integer(in the middle of the grid)
	Vector2 snapToGrid(Vector2 rawWorldPos){
		Vector2 finalPos;
		//Using the RoundToInt to deal with the mouse click position
		int xPos = Mathf.RoundToInt (rawWorldPos.x);
		int yPos = Mathf.RoundToInt (rawWorldPos.y);
		finalPos = new Vector2 (xPos, yPos);
		return finalPos;
	}
}

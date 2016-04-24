using UnityEngine;
using System.Collections;

public class AttackerController : MonoBehaviour {

	[Range(-1f, 2f)]
	public float currentWalkingSpeed;		//Define the attacker's walk speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentWalkingSpeed * Time.deltaTime);		//Update the attacker's location by using transform
	}

	//To detect the collision with other game object
	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log("Detect a collision!");
	}

	//To set the walking speed (in animation)
	public void SetWalkingSpeed(float walkingSpeed){
		currentWalkingSpeed = walkingSpeed;
	}

	//To set the damage of the attacker(in animation)
	public void StrickCurrentTarget(float damage){
		Debug.Log (name + " caused " + damage + " damage");
	}
}

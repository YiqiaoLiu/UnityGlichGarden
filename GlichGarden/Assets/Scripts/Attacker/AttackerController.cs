using UnityEngine;
using System.Collections;

public class AttackerController : MonoBehaviour {

	private float currentWalkingSpeed;													//Define the attacker's walk speed;
	private GameObject currentAttackTarget;												//Define the attacker's current target
	private Animator anim;																//Define the attacker's Animator
	public float spawnRate;																//Define the attacker spawn rate

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();												//Get the Animator variable
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentWalkingSpeed * Time.deltaTime);		//Update the attacker's location by using transform

		//To check whether the current target status
		if (currentAttackTarget == null) {										
			anim.SetBool ("isAttacking", false);										//Reset the isAttacking variable to ensure the right animation transition
		}
	}

	//To detect the collision with other game object
	void OnTriggerEnter2D(Collider2D col) {
		//Debug.Log("Detect a collision!");
	}

	//To set the walking speed (in animation)
	public void SetWalkingSpeed(float walkingSpeed){
		currentWalkingSpeed = walkingSpeed;
	}

	//To set the damage of the attacker(in animation)
	public void StrickCurrentTarget(float damage){
		if (currentAttackTarget != null) {
			Healthy healthy = currentAttackTarget.GetComponent<Healthy>();				//Get the defender's healthy script
			healthy.GetDamage(damage);													//Using the function in the script to deal the damage
		}
		Debug.Log (name + " caused " + damage + " damage");
	}

	public void Attack (GameObject obj){
		currentAttackTarget = obj;																//Get the current target of the attacker (using in specific attacker's script)
		Debug.Log (gameObject.name + " Attacking: " + currentAttackTarget.name);
	}
}

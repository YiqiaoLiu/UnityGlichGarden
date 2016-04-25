using UnityEngine;
using System.Collections;

public class FoxSpecial : MonoBehaviour {

	private Animator anim;					//Define the Animator variable
	private AttackerController attacker;	//Define the AttackerController variable

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();					//Get the Animator of the gameobject
		attacker = GetComponent<AttackerController> ();		//Get the AttackerController of the gameobject
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){

		//Check that whether the collision is defender or bullet
		if (col.GetComponent<DefenderController> () == null) {
			return;
		}

		//Check that whether the collision is stone or other defender
		if (col.name == "Stone") {
			anim.SetTrigger ("isJumping");
		} else {
			attacker.Attack(col.gameObject);
			anim.SetBool("isAttacking", true);
		}
	}
}

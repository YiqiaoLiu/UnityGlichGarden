using UnityEngine;
using System.Collections;

public class LizardSpecial : MonoBehaviour {

	private Animator anim;									//Define the Animator variable
	private AttackerController attacker; 					//Define the AttackerController viriable (in order to call attack function)
	private float lizardHP;									//Define the HP of lizard

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();					//Get the Animator variable
		attacker = GetComponent<AttackerController> ();		//Get the AttackerController viriable
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		//To check whether the collision is defender or not
		if (col.GetComponent<DefenderController> () == null) {
			return;
		} else {
			attacker.Attack(col.gameObject);
			anim.SetBool ("isAttacking", true);
		}
	}	
}

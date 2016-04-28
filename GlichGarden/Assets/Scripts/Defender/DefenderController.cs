using UnityEngine;
using System.Collections;

public class DefenderController : MonoBehaviour {
	
	private Shooter shoot;						//Define the shooter variable
	private Animator anim;						//Define the Animator variable


	// Use this for initialization
	void Start () {
		shoot = GetComponent<Shooter> ();		//Get the shooter variable
		anim = GetComponent<Animator> ();		//Get the Animator variable
	}
	
	// Update is called once per frame
	void Update () {

	}
	
}

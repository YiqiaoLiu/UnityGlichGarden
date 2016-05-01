using UnityEngine;
using System.Collections;

public class DefenderController : MonoBehaviour {
	
	private Shooter shoot;						//Define the shooter variable
	private Animator anim;						//Define the Animator variable
	private ShowStarNumber star;				//Define the star variable
	public int defenderCost = 100;				//Define the cost of the defender


	// Use this for initialization
	void Start () {
		shoot = GetComponent<Shooter> ();							//Get the shooter variable
		anim = GetComponent<Animator> ();							//Get the Animator variable
		star = GameObject.FindObjectOfType<ShowStarNumber> ();		//Get the ShowStarNumber variable
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void addStar(int vol){
		star.addStarNumber (vol);									//Add the number of the star
	}
	
}

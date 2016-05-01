using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowStarNumber : MonoBehaviour {

	public Text starNumber;						//Define the Text variable
	private int currentStarNumber;				//Store the current number of star
	public enum Status {SCCUESS, FAIL};			//Define the status enum variable

	// Use this for initialization
	void Start () {
		currentStarNumber = 200;				//Set the initial star number
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Add starNumber
	public void addStarNumber(int vol){
		currentStarNumber += vol;				//Add the value in the current star number
		updateStarNumber ();					//Update the star number
	}

	//Cost starNumber
	public Status costStarNumber(int vol){

		//Check whether the current star number is lager than the cost
		//If yes, update the number of star and return a success status
		//If not, return the fail status
		if (currentStarNumber >= vol) {
			currentStarNumber -= vol;
			updateStarNumber ();
			return Status.SCCUESS;
		} else {
			return Status.FAIL;
		}

	}

	//Update the UI text
	public void updateStarNumber(){
		starNumber.text = currentStarNumber.ToString ();
	}	
}

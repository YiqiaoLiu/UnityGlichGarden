using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowStarNumber : MonoBehaviour {

	public Text starNumber;						//Define the Text variable
	private int currentNumber;					//Store the current number of star

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Add starNumber
	public void addStarNumber(int vol){
		currentNumber += vol;
		updateStarNumber ();
	}

	public void updateStarNumber(){
		starNumber.text = currentNumber.ToString ();
	}


}

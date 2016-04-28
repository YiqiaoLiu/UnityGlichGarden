﻿using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	private ButtonController[] buttonArray;		//Store all the button in the button field
	private SpriteRenderer buttonImage;			//Define the image of the button

	void Start() {
		buttonArray = GameObject.FindObjectsOfType<ButtonController> ();	//Set the button array accroding to the type
		buttonImage = GetComponent<SpriteRenderer> ();						//Get the image of the button
	}

	void OnMouseDown(){

		//First, when mouse click, set all the image black(dark)
		foreach (ButtonController currentButton in buttonArray) {
			currentButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		//Second, set the clicked button's image white(bright)
		buttonImage.color = Color.white;
	}

}

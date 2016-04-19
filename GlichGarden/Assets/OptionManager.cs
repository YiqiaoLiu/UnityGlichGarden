using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionManager : MonoBehaviour {

	public Slider volumeSlider;			//To get the volume slider UI
	public Slider difficultySlider;		//To get the difficulty slider UI
	private MusicManager musicManager;	//To get the musicManager to change volume
	private float musicVolume;			//The changing music volume
	private float difficultyVolume;		//The changing difficulty volume

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();		//By using find to instantiate the musicManager
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();		//Ensure that each time load the scene the slider shows the current volume
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();	//Ensure that each time load the scene the slider shows the current difficulty
	}

	void Update() {
		musicVolume = volumeSlider.value;								//Get the music slider(change) volume
		difficultyVolume = difficultySlider.value;						//Get the difficulty slider(change) volume
		musicManager.changeMusicVolume (musicVolume);					//change the volume
	}

	//Save the value set in the scene and exit to the start scene
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (musicVolume);				//Save the changing music volume
		PlayerPrefsManager.SetDifficulty (difficultyVolume);			//Save the changing difficulty volume
		Application.LoadLevel (Application.loadedLevel - 1);			//In order to be used by the UI button
	}

	//Set the default value
	public void SetDefault() {
		volumeSlider.value = 0.5f;										//Set the default music volume is median volume
		difficultySlider.value = 2f;									//Set the default difficulty volume is median volume
	}

}

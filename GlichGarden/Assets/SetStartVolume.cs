using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicManager musicManager;		//Define the music manager variant
	private float musicVolume;				//Define the volume of the music

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();		//Instantiate the music manager by finding the type
		if (musicManager) {
			musicVolume = PlayerPrefsManager.GetMasterVolume();
			musicManager.changeMusicVolume(musicVolume);
		}else{
			Debug.LogError("Cannot find music manager!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

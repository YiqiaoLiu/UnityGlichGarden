using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelTimeController : MonoBehaviour {

	private Slider timeSlider;								//Define the Slider variable
	private float startTime;								//Define the Start time variable
	private float levelTime;								//Define the level time						
	public AudioClip audioClip;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		timeSlider = GetComponent<Slider> ();				//Get the Slider Component
		timeSlider.value = 1;								//Set the initial slider volume is 1(max)
		startTime = Time.timeSinceLevelLoad;				//Set the start time of this level
		levelTime = 10f;									//Define the level time
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {	
		float intervalTime = Time.time - startTime;						//Calculate the spend time					
		timeSlider.value = (levelTime - intervalTime) / levelTime;		//Define the volume of the slider
		Debug.Log (timeSlider.value);
		if (timeSlider.value == 1f && audioSource == null) {
			Debug.Log("000");
			audioSource.clip = audioClip;
			audioSource.Play();
		}
	}
}

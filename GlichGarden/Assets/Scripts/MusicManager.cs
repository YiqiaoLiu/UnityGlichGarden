using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicChangeArray;
	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start() {
		audioSource = GetComponent<AudioSource> ();
	}

	void OnLevelWasLoaded(int level){
		AudioClip currentLevelMusic = musicChangeArray[level];
		/*
		if (level == 1 || level == 2) {
			currentLevelMusic = musicChangeArray [1];
		} else if (level == 3) {
			currentLevelMusic = musicChangeArray [2];
		} else if (level == 4) {
			currentLevelMusic = musicChangeArray [3];
		}
*/
		if(currentLevelMusic != null){
			audioSource.clip = currentLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	public void changeMusicVolume(float musicVolume){
		audioSource.volume = musicVolume;
	}
}

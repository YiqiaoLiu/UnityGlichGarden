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

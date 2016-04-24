using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";				//The key of the music volume
	const string LEVEL_UNLOCKED_KEY = "level_unlocked_";			//The key of the unlocked level
	const string DIFF_KEY = "difficulty";							//The key of the difficulty

	//Set and get the master volume by playerprefs
	public static void SetMasterVolume(float MasterVolume){
		//check the range of the input volume
		if (MasterVolume > 0f && MasterVolume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, MasterVolume);
		} else {
			Debug.LogError("The master volume is out of range!");
		}
	}

	//Get the volume of the music
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	//Set the unlocked levels
	public static void SetUnlockLevel(int level){
		//Check the range of the input level
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_UNLOCKED_KEY + level.ToString(), 1);   //Use 1 for unlock this level
		} else {
			Debug.LogError("The level index is out of range!");
		}
	}

	//Check whether the level is unlocked
	public static bool IsLevelUnlocked(int level){
		//Check the range of the input level
		if (level <= Application.levelCount - 1) {
			if (PlayerPrefs.GetInt (LEVEL_UNLOCKED_KEY + level.ToString()) == 1) {
				return true;
			} else {
				return false;
			}
		} else {
			Debug.LogError("The level index is out of range!");
			return false;													//If the input level is out of range, return false
		}
	}


	//Set the difficulty of the game
	public static void SetDifficulty(float volume){
		//Check the range of the input volume 
		if (volume >= 1f && volume <= 3f) {
			PlayerPrefs.SetFloat(DIFF_KEY, volume);
		} else {
			Debug.LogError("The difficulty level is out of range!");
		}
	}

	//Get the difficulty of the game
	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat (DIFF_KEY);
	}


}

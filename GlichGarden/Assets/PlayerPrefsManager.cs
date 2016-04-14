using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_UNLOCKED_KEY = "level_unlocked_";

	//Set and get the master volume by playerprefs
	public static void SetMasterVolume(float MasterVolume){
		if (MasterVolume > 0f && MasterVolume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, MasterVolume);
		} else {
			Debug.LogError("The master volume is out of range!");
		}
	}
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	//Set the unlocked levels
	public static void SetUnlockLevel(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_UNLOCKED_KEY + level.ToString(), 1);   //Use 1 for unlock this level
		} else {
			Debug.LogError("The level index is out of range!");
		}
	}

	//Check whether the level is unlocked
	public static bool IsLevelUnlocked(int level){
		if (level <= Application.levelCount - 1) {
			if (PlayerPrefs.GetInt (LEVEL_UNLOCKED_KEY + level.ToString()) == 1) {
				return true;
			} else {
				return false;
			}
		} else {
			Debug.LogError("The level index is out of range!");
			return false;
		}
	}

}

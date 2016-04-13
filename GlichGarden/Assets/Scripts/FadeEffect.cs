using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeEffect : MonoBehaviour {

	private Image fadePanel;
	private float fadeInTime = 1.0f;
	private float fadeOutTime = 3.0f;
	private float fadeEndTime = 4.0f;

	private Color currentColor = Color.white;
	private bool isSplash = false;
	

	// Use this for initialization
	void Start () {
		//Since the Splash and the start scene need to take different stratege
		//So need check in Start function
		if (Application.loadedLevel == 0) {
			isSplash = true;
		}
		if (isSplash) {
			currentColor = Color.white;
		} else {
			fadeInTime = 3.0f;
			currentColor = Color.black;
		}

		fadePanel = GetComponent<Image>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} 
		if (Time.timeSinceLevelLoad > fadeOutTime && Time.timeSinceLevelLoad < fadeEndTime && isSplash) {
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a += alphaChange;
			fadePanel.color = currentColor;
		}
	}
}

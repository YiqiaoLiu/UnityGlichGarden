using UnityEngine;
using System.Collections;

public class Healthy : MonoBehaviour {

	public float healthy = 100f;				//Define the object's HP

	//To deal with the damage from other
	public void GetDamage(float damage){
		healthy -= damage;
		Debug.Log (gameObject.name + healthy);
		//Check whether the damage less than 0
		if (healthy <= 0) {
			Destroy(gameObject);
		}
	}

}

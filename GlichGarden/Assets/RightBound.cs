using UnityEngine;
using System.Collections;

public class RightBound : MonoBehaviour {

	//If some object out of this bound destroy it!
	void OnTriggerEnter2D(Collider2D col){
		Destroy (col.gameObject);
	}
}

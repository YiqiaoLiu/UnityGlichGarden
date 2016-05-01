using UnityEngine;
using System.Collections;

public class LoseTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		AttackerController attacker = col.gameObject.GetComponent<AttackerController> ();
		if (attacker != null) {
			Application.LoadLevel("03b Lose");
		}
	}
}

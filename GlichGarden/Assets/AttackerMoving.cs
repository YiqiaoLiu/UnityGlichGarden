using UnityEngine;
using System.Collections;

public class AttackerMoving : MonoBehaviour {

	[Range (-1f, 2f)]
	public float walkingSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkingSpeed * Time.deltaTime);
	}
}

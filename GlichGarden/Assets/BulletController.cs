using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	private float bulletSpeed = 5f;
	public float bulletDamage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * bulletSpeed * Time.deltaTime);
	}
}

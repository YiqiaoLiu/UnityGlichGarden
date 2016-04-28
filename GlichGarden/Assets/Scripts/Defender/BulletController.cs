using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	private float bulletSpeed = 5f;			//Define the bullet's velocity
	public float bulletDamage;				//Define the bullet's damage
	private Healthy healthy;				//Define the healthy variable (It is the attacker's healthy)


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * bulletSpeed * Time.deltaTime);				//Define the position update
	}

	//Deal the collision of the bullet
	void OnTriggerEnter2D(Collider2D col){

		//Check the collider is attacker according to the tag
		if (col.gameObject.tag == "Attacker") {
			healthy = col.GetComponent<Healthy>();					//Get the attacker's healthy component
			healthy.GetDamage(bulletDamage);						//Counting the damage
			Destroy(gameObject);									//Destory the bullet when the collision happen
		} else {
			return;													//If the collision did not happen on the attacker, just return
		}
	}
}

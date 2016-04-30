using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject Bullet;			//Define the object of the bullet
	public GameObject BulletPos;		//This object is in order to define the initial position of the bullet
	public GameObject BulletParent;		//This object is in order to store the instantiated bullet when game runs

	private Animator anim;				//Define the Animator variable of the defender

	/*This is the way of using script to control the fire rate
	 * 
	public float fireRate;				//Define the fireRate
	private float lastFireTime;			//This variable is to store the last fire time
	private float intervalTime;			//This variable is to store the interval time between 2 fire

	public void Fire(){
		//intervalTime = Time.time - lastFireTime;	//Calculate the interval between request fire and last fire
		//Check the time larger than the fire rate
		//if (intervalTime >= fireRate) {
		GameObject newBullet = Instantiate (Bullet, BulletPos.transform.position, Quaternion.identity) as GameObject;	//Instantiate a bullet at the define pos
		//lastFireTime = Time.time;																						//Update the fire time
		//}
	}
	*/

	void Start() {
		//Check whether the Bullet GameObject existed, if not, created a new one
		BulletParent = GameObject.Find("Bullet");
		if (BulletParent == null) {
			BulletParent = new GameObject("Bullet");
		}
		anim = GetComponent<Animator> ();																				//Get the Animator attribute of the defender
	}

	void Update(){
		//According to the detect result, set the attacking bool variable
		if (detectAttacker ()) {
			anim.SetBool ("isAttacking", true);
		} else {
			anim.SetBool ("isAttacking", false);
		}
	}

	//Detect attacker function
	bool detectAttacker(){
		float lineIndex = transform.position.y;																			//Using the y position to determine the line index
		GameObject thisLine = GameObject.Find ("SpawnLine" + lineIndex.ToString ());									//According to the line index find the spawnline object
		int attackerNumber = thisLine.transform.childCount;																//Using the childCount to count the child object(attacker number)

		//If the number lager than 0 means detect attacker
		if (attackerNumber > 0) {
			return true;
		} else {
			return false;
		}
	}

	public void Fire(){
		GameObject newBullet = Instantiate (Bullet, BulletPos.transform.position, Quaternion.identity) as GameObject;	//Instantiate a bullet at the define pos
		newBullet.transform.parent = BulletParent.transform;															//Locate the bullet into the Bullet GameObject
	}
}

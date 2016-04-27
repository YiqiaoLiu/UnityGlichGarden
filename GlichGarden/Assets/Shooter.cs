﻿using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject Bullet;			//Define the object of the bullet
	public GameObject BulletPos;		//This object is in order to define the initial position of the bullet
	public float fireRate;				//Define the fireRate
	private float lastFireTime;			//This variable is to store the last fire time
	private float intervalTime;			//This variable is to store the interval time between 2 fire

	public void Fire(){
		intervalTime = Time.time - lastFireTime;	//Calculate the interval between request fire and last fire
		//Check the time larger than the fire rate
		if (intervalTime >= fireRate) {
			GameObject newBullet = Instantiate (Bullet, BulletPos.transform.position, Quaternion.identity) as GameObject;	//Instantiate a bullet at the define pos
			lastFireTime = Time.time;																						//Update the fire time
		}
	}
}

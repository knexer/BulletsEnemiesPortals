﻿using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject bullet;

    private float lastBulletTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time - lastBulletTime >= 1.6) {
            spawnBullet();
            lastBulletTime = Time.time;
        }
	}

    private void spawnBullet() {
        GameObject bulletInst = (GameObject) Instantiate(bullet, transform.position, bullet.transform.rotation);
        bulletInst.rigidbody2D.velocity = new Vector2(-3, 0);
    }
}
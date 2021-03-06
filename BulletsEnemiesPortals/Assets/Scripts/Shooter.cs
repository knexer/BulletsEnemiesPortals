﻿using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public Bullet bullet;
    public float startingVelocity = 6;
    public Direction startingDirection = Direction.Left;

    private float lastBulletTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time - lastBulletTime >= 1.5) {
            spawnBullet();
            lastBulletTime = Time.time;
        }
	}

    private void spawnBullet() {
        bool isLeft = startingDirection == Direction.Left;
        GameObject bulletInst = (GameObject) Instantiate(bullet.gameObject, transform.position, Quaternion.Euler(0, 0, (isLeft ? 1 : -1) * 90));
        bulletInst.rigidbody2D.velocity = new Vector2((isLeft ? -1 : 1) * startingVelocity, 0);
    }
}

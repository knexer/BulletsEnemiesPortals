using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public Bullet bullet;

    private float lastBulletTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time - lastBulletTime >= 0.7) {
            spawnBullet();
            lastBulletTime = Time.time;
        }
	}

    private void spawnBullet() {
        GameObject bulletInst = (GameObject) Instantiate(bullet.gameObject, transform.position, bullet.gameObject.transform.rotation);
        bulletInst.rigidbody2D.velocity = new Vector2(-6, 0);
    }
}

using UnityEngine;
using System.Collections;

public class MakeRandomBullets : BulletGenerator {

	// Use this for initialization
	void Start () {
        base.Start();
        StartCoroutine(FireBulletsCoroutine());
	}

    IEnumerator FireBulletsCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeBetweenBullets);
            FireBullet();
        }
    }

    void FireBullet()
    {
        float altitude = Random.value;
        float xPosition = Side == Direction.Left ? lowerAreaBoundaries.xMin - OffscreenDistance : lowerAreaBoundaries.xMax + OffscreenDistance;
        Debug.Log(lowerAreaBoundaries);
        Vector3 position = new Vector3(xPosition, lowerAreaBoundaries.yMin + altitude * lowerAreaBoundaries.height, 0);
        GameObject bullet = (GameObject)Instantiate(BulletToFire, position, Quaternion.Euler(0, 0, Side == Direction.Left ? -90 : 90));
        bullet.rigidbody2D.velocity = new Vector2(Side == Direction.Left ? BulletSpeed : -BulletSpeed, 0);
    }
}

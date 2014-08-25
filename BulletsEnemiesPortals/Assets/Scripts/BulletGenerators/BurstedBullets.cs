using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class BurstedBullets : BulletGenerator
{
    public int NumBulletsInBurst;
    public float BurstDuration;
    public float PositionOfOriginRange;
    public float YVelocityRange;


    // Use this for initialization
    void Start()
    {
        base.Start();
        StartCoroutine(FireBulletsCoroutine());
    }

    IEnumerator FireBulletsCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeBetweenBullets);
            StartCoroutine(FireBulletBurst());
        }
    }

    IEnumerator FireBulletBurst()
    {
        float baseAltitude = Random.value;
        float xPosition = Side == Direction.Left ? lowerAreaBoundaries.xMin - OffscreenDistance : lowerAreaBoundaries.xMax + OffscreenDistance;
        float xVelocity = Side == Direction.Left ? BulletSpeed : -BulletSpeed;

        for (int i = 0; i < NumBulletsInBurst; i++)
        {
            FireBullet(baseAltitude, xPosition, xVelocity);
            yield return new WaitForSeconds(BurstDuration / NumBulletsInBurst - 1);
        }
    }

    void FireBullet(float baseAltitude, float xPosition, float xVelocity)
    {
        float altitude = baseAltitude + Random.value * PositionOfOriginRange - PositionOfOriginRange / 2.0f;
        if (altitude > 1) altitude = 1;
        if (altitude < 0) altitude = 0;

        float yVelocity = Random.value * YVelocityRange - YVelocityRange / 2.0f;

        float angle = Mathf.Atan2(yVelocity, xVelocity);

        Vector3 position = new Vector3(xPosition, altitude * lowerAreaBoundaries.height + lowerAreaBoundaries.yMin, 0);

        GameObject bullet = (GameObject) Instantiate(BulletToFire, position, Quaternion.Euler(0, 0, angle));
        bullet.rigidbody2D.velocity = new Vector2(xVelocity, yVelocity);
    }
}

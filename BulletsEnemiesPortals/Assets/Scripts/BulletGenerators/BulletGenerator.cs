using UnityEngine;
using System.Collections;

public abstract class BulletGenerator : MonoBehaviour {

    public GameObject BulletToFire;
    public Direction Side;
    public PlayAreaBoundaries GameBoundaries;
    public float OffscreenDistance;

    public float TimeBetweenBullets;
    public float BulletSpeed;

    protected Rect lowerAreaBoundaries;

	// Use this for initialization
	protected void Start () {
        lowerAreaBoundaries = GameBoundaries.LowerWorld;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

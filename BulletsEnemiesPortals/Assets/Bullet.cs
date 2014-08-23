using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float startingAngularVelocity = 0;

	// Use this for initialization
	void Start () {
        rigidbody2D.angularVelocity = startingAngularVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

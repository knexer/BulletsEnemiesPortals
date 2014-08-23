using UnityEngine;
using System.Collections;
using System;

public class InPortal : MonoBehaviour {

    public OutPortal pair;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {
        Bullet b = col.gameObject.GetComponent<Bullet>();
        if (b == null) return;

        col.gameObject.transform.position = pair.transform.position;
        Vector2 prevV = col.gameObject.rigidbody2D.velocity;
        col.gameObject.rigidbody2D.velocity = new Vector2(prevV.y, -prevV.x);
        col.gameObject.transform.Rotate(new Vector3(0, 0, 1), -90);
    }
}

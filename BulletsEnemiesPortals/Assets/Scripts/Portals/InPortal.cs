using UnityEngine;
using System.Collections;
using System;

public class InPortal : MonoBehaviour {

    public OutPortal[] pairs;
    public AudioClip soundEffect;

    private AudioSource sound;

	// Use this for initialization
	void Start () {
        sound = gameObject.AddComponent<AudioSource>();
        sound.clip = soundEffect;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {
        Bullet b = col.gameObject.GetComponent<Bullet>();
        if (b == null) return;

        Vector2 prevV = col.gameObject.rigidbody2D.velocity;
        col.gameObject.transform.Rotate(new Vector3(0, 0, 1), -90);
        sound.Play();

        foreach (OutPortal pair in pairs)
        {
            GameObject clone = (GameObject)Instantiate(col.gameObject);
            clone.transform.position = pair.transform.position;
            clone.rigidbody2D.velocity = new Vector2(prevV.y, -prevV.x);
        }

        Destroy(col.gameObject);
    }
}

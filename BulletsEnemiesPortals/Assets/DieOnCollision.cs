using UnityEngine;
using System.Collections;

public class DieOnCollision : MonoBehaviour {

    public LayerMask LayerMask;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void checkAndDie(GameObject other)
    {
        if ((LayerMask & 1 << other.layer) > 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        checkAndDie(other.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        checkAndDie(other.gameObject);
    }
}

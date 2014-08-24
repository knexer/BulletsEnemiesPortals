using UnityEngine;
using System.Collections;

public class DamageOtherOnCollision : MonoBehaviour {

    public LayerMask LayerMask;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void checkAndDestroy(GameObject other) {
        if ((LayerMask & 1 << other.gameObject.layer) > 0) {
            TakeDamage damageDealer = other.GetComponent<TakeDamage>();
            if (damageDealer != null) {
                damageDealer.takeDamage(1);
            } else {
                Destroy(other.gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        checkAndDestroy(other.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        checkAndDestroy(other.gameObject);
    }
}

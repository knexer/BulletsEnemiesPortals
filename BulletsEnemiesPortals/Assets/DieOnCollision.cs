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

    void OnCollisionEnter2D(Collision2D other)
    {
        if ((LayerMask & 1 << other.gameObject.layer) > 0)
        {
            Destroy(gameObject);
        }
    }
}

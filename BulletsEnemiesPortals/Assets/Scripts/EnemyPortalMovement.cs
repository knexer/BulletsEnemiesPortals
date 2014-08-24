using UnityEngine;
using System.Collections;

public class EnemyPortalMovement : MonoBehaviour {
    public float move_direction = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if( move_direction > 0f && transform.position.x > 7.0f ||
            move_direction < 0f && transform.position.x < -7.0f ) {
            move_direction = -move_direction;
        }

        transform.position += new Vector3(move_direction * 0.01f, 0, 0);
	}
}

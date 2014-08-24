using UnityEngine;
using System.Collections;

public class ShooterMover : MonoBehaviour {

    public float minY, maxY;
    public Direction startingDirection = Direction.Down;
    public float speed;

    private Direction dir;

	// Use this for initialization
	void Start () {
        dir = startingDirection;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3(0, speed * (dir == Direction.Up ? -1 : 1), 0);

        if (transform.position.y > maxY) {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            dir = Direction.Up;
        }

        if (transform.position.y < minY) {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
            dir = Direction.Down;
        }
	}
}

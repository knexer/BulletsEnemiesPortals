using UnityEngine;
using System.Collections;

public class BindToBounds : MonoBehaviour {

    public PlayAreaBoundaries bounds;
    public World worldToBindTo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Rect myBounds = worldToBindTo == World.UPPER ? bounds.UpperWorld : bounds.LowerWorld;

        float newX = transform.position.x;
        if (transform.position.x + gameObject.collider2D.bounds.extents.x > myBounds.xMax) {
            newX = myBounds.xMax - gameObject.collider2D.bounds.extents.x;
        } else if (transform.position.x - gameObject.collider2D.bounds.extents.x < myBounds.xMin) {
            newX = myBounds.xMin + gameObject.collider2D.bounds.extents.x;
        }

        float newY = transform.position.y;
        if (transform.position.y + gameObject.collider2D.bounds.extents.y > myBounds.yMax) {
            newY = myBounds.yMax - gameObject.collider2D.bounds.extents.y;
        } else if (transform.position.y - gameObject.collider2D.bounds.extents.y < myBounds.yMin) {
            newY = myBounds.yMin + gameObject.collider2D.bounds.extents.y;
        }

        transform.position = new Vector3(newX, newY, transform.position.z);
	}

    public enum World {
        UPPER, LOWER
    }
}

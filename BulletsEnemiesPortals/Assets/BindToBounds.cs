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
        if (transform.position.x > myBounds.xMax) {
            newX = myBounds.xMax;
        } else if (transform.position.x < myBounds.xMin) {
            newX = myBounds.xMin;
        }

        float newY = transform.position.y;
        if (transform.position.y > myBounds.yMax) {
            newY = myBounds.yMax;
        } else if (transform.position.y < myBounds.yMin) {
            newY = myBounds.yMin;
        }
	}

    public enum World {
        UPPER, LOWER
    }
}

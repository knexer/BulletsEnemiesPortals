using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimpleEnemyMovement : MonoBehaviour
{
    public enum Direction { Right, Left, Down };

    public GameObject playAreaBoundsHolder;

    public float width;

    public float velocity;
    public float verticalStepSize;
    public Direction InitialDirection;

    private Rect playAreaBounds;
    
    private Direction currentDirection;
    private float nextVerticalStepHeight;

    private Dictionary<Direction, Vector3> unitVectors = new Dictionary<Direction, Vector3>
    {
        {Direction.Left, Vector3.left},
        {Direction.Right, Vector3.right},
        {Direction.Down, Vector3.down}
    };

	// Use this for initialization
	void Start () {
        playAreaBounds = playAreaBoundsHolder.GetComponent<PlayAreaBoundaries>().UpperWorld;
        currentDirection = InitialDirection;
        if (currentDirection == Direction.Down) StartDown();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += unitVectors[currentDirection] * velocity;
        switch (currentDirection)
        {
            case Direction.Left:
                if (transform.position.x - width / 2.0f <= playAreaBounds.xMin)
                {
                    transform.position = new Vector3(playAreaBounds.xMin, transform.position.y, transform.position.z);
                    currentDirection = Direction.Down;
                    StartDown();
                }
                break;
            case Direction.Right:
                if (transform.position.x + width / 2.0f >= playAreaBounds.xMax)
                {
                    transform.position = new Vector3(playAreaBounds.xMax, transform.position.y, transform.position.z);
                    currentDirection = Direction.Down;
                    StartDown();
                }
                break;
            case Direction.Down:
                if (transform.position.y < nextVerticalStepHeight)
                {
                    if (transform.position.x < 0) currentDirection = Direction.Right;
                    else currentDirection = Direction.Left;
                }
                break;
        }
	}

    private void StartDown()
    {
        nextVerticalStepHeight = transform.position.y - verticalStepSize;
    }
}

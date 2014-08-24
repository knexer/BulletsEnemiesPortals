using UnityEngine;
using System.Collections;

public class TrackOther : MonoBehaviour {

    public GameObject other;
    public float yMultiplier = 1, xMultiplier = 1;

    private Vector3 prevPosition;

	// Use this for initialization
	void Start () {
        prevPosition = other.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = other.transform.position - prevPosition;
        delta.x *= xMultiplier;
        delta.y *= yMultiplier;
        transform.position += delta;
        prevPosition = other.transform.position;
	}
}

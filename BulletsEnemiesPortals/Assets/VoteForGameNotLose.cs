using UnityEngine;
using System.Collections;

public class VoteForGameNotLose : MonoBehaviour {

    static int numVotes = 0;

	// Use this for initialization
	void Start () {
        numVotes++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        numVotes--;
        if (numVotes <= 0)
        {
            Debug.Log("YOU ARE NOW LOSE");
        }
    }
}

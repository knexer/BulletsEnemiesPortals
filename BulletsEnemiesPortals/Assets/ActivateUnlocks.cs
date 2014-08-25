using UnityEngine;
using System.Collections;

public class ActivateUnlocks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    foreach(UnlockData unlock in FindObjectsOfType<UnlockData>())
        {
            unlock.ActivateUnlock();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

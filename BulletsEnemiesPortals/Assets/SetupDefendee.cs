using UnityEngine;
using System.Collections;

public class SetupDefendee : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OptionsDictionary options = FindObjectOfType<OptionsDictionary>();

        this.GetComponent<SpriteRenderer>().sprite = options.friendlyWorld.friendly.GetComponent<SpriteRenderer>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

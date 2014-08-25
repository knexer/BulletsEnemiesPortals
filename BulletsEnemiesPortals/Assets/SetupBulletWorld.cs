using UnityEngine;
using System.Collections;

public class SetupBulletWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OptionsDictionary options = FindObjectOfType<OptionsDictionary>();

        this.GetComponent<SpriteRenderer>().sprite = options.bulletWorld.background;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

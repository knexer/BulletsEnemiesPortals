using UnityEngine;
using System.Collections;

public class SetupShooter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OptionsDictionary options = FindObjectOfType<OptionsDictionary>();

        this.GetComponent<Shooter>().bullet = options.bulletWorld.bullet;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

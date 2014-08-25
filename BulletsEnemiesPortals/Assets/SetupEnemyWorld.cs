using UnityEngine;
using System.Collections;

public class SetupEnemyWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OptionsDictionary options = FindObjectOfType<OptionsDictionary>();

        this.GetComponent<SpriteRenderer>().sprite = options.enemyWorld.background;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

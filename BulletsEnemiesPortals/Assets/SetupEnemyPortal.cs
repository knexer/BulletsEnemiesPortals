using UnityEngine;
using System.Collections;

public class SetupEnemyPortal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OptionsDictionary options = FindObjectOfType<OptionsDictionary>();

        this.GetComponent<EnemyPortalSpawning>().spawnee = options.enemyWorld.enemy;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

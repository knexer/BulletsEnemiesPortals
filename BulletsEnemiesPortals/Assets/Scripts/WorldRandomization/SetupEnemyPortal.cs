using UnityEngine;
using System.Collections;

public class SetupEnemyPortal : MonoBehaviour {

	void Start () {
        this.GetComponent<EnemyPortalSpawning>().spawnee = OptionsDictionary.instance.enemyWorld.enemy;
	}
}

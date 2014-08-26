using UnityEngine;
using System.Collections;

public class MorePortalHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] enemyPortals = GameObject.FindGameObjectsWithTag("EnemyPortal");
        foreach(GameObject enemyPortal in enemyPortals){
            TakeDamage hp = enemyPortal.GetComponent<TakeDamage>();
            hp.HP = hp.HP * 2;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

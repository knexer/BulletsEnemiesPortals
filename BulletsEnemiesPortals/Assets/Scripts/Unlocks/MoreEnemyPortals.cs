using UnityEngine;
using System.Collections;

public class MoreEnemyPortals : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject enemyPortal = GameObject.Find("EnemyPortal");
        GameObject newEnemyPortal = (GameObject)Instantiate(enemyPortal);

        PlayAreaBoundaries boundary = FindObjectOfType<PlayAreaBoundaries>();
        float midX = boundary.UpperWorld.center.x;
        Vector3 currentPosition = newEnemyPortal.transform.position;

        newEnemyPortal.transform.position = new Vector3(midX - (currentPosition.x - midX), currentPosition.y, currentPosition.z);
        newEnemyPortal.GetComponent<SimpleEnemyMovement>().SwitchDirections();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

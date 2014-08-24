using UnityEngine;
using System.Collections;

public class EnemyPortalSpawning : MonoBehaviour {
    public float lastSpawn;
    public float spawnRate;
    public GameObject spawnee;
	// Use this for initialization
	void Start () {
        lastSpawn = Time.time;
        spawnRate = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastSpawn > spawnRate) {
            spawnEnemy();
            lastSpawn = Time.time;
        }
	}

    private void spawnEnemy() {
        GameObject enemyInst = (GameObject) Instantiate(spawnee, transform.position, spawnee.transform.rotation);
    }
}

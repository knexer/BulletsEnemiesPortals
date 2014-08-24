using UnityEngine;
using System.Collections;

public class EnemyPortalSpawning : MonoBehaviour {
    private float lastSpawn;
    public float spawnRate;
    public Enemy spawnee;
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
        Instantiate(spawnee.gameObject, transform.position, spawnee.gameObject.transform.rotation);
    }
}

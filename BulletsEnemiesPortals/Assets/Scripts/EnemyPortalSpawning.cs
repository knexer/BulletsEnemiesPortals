using UnityEngine;
using System.Collections;

public class EnemyPortalSpawning : MonoBehaviour {
    private float lastSpawn;
    public float spawnRate = 2.0f;
    public Enemy spawnee;
	// Use this for initialization
	void Start () {
        lastSpawn = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastSpawn > spawnRate) {
            spawnEnemy();
            lastSpawn = Time.time;
        }
	}

    private void spawnEnemy() {
        Instantiate(spawnee.gameObject, transform.position + new Vector3(0, -0.5f, 0), spawnee.gameObject.transform.rotation);
    }
}

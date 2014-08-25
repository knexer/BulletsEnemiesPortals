using UnityEngine;
using System.Collections;
using System;

public class OptionsDictionary : MonoBehaviour {
    public static OptionsDictionary instance { get; private set; }

    public WorldType bulletWorld;
    public WorldType enemyWorld;
    public WorldType friendlyWorld;

	// Use this for initialization
	void Awake () {
        instance = this;
        WorldType[] worlds = gameObject.GetComponentsInChildren<WorldType>();

        System.Random gen = new System.Random();
        bulletWorld = worlds[gen.Next(worlds.Length)];
        enemyWorld = worlds[gen.Next(worlds.Length)];
        friendlyWorld = worlds[gen.Next(worlds.Length)];

        Debug.LogError("Bullet world: " + bulletWorld.worldName + " - Friendly world: " + friendlyWorld.worldName + " - Enemy world: " + enemyWorld.worldName);
	}
}

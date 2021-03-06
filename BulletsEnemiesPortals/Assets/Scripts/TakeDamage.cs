﻿using UnityEngine;
using System.Collections;
using System;

public class TakeDamage : MonoBehaviour {
    public int HP;
    public AudioClip soundEffectTakeDamage;
    public AudioClip soundEffectDie;

    private GameObject audioSource;

    public event Action OnDeath;

	void Start () {
        audioSource = new GameObject();
        audioSource.AddComponent<AudioSource>();
	}

    public bool takeDamage(int damage) {
        HP -= damage;
        if (HP <= 0) {
            audioSource.transform.position = this.transform.position;
            audioSource.audio.clip = soundEffectDie;
            audioSource.audio.Play();
            if (OnDeath != null) {
                OnDeath();
            }
            Destroy(gameObject);
            return true;
        }

        audioSource.transform.position = this.transform.position;
        audioSource.audio.clip = soundEffectTakeDamage;
        audioSource.audio.Play();
        return false;
    }
}

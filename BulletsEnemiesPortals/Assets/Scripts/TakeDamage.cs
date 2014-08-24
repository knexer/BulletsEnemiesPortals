using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {
    public int HP;
    public AudioClip soundEffectTakeDamage;
    public AudioClip soundEffectDie;

    private GameObject audioSource;

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
            Destroy(gameObject);
            return true;
        }

        audioSource.transform.position = this.transform.position;
        audioSource.audio.clip = soundEffectTakeDamage;
        audioSource.audio.Play();
        return false;
    }
}

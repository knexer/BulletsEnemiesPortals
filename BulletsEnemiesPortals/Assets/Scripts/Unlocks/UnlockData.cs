using UnityEngine;
using System.Collections;

public class UnlockData : MonoBehaviour {

    public Sprite sprite;
    public Texture texture;
    public string name;
    public string description;

    public bool isActivated = false;
    public bool isUnlocked = false;

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
}

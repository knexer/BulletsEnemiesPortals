using UnityEngine;
using System.Collections;

public class UnlockData : MonoBehaviour {

    public Sprite sprite;
    public Texture texture;
    public string name;
    public string description;

    public bool isActivated = false;
    public bool isUnlocked = false;

    public GameObject UnlockEffector;

    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    public void ActivateUnlock()
    {
        if (isActivated && null != UnlockEffector)
        {
            GameObject instantiatedEffector = (GameObject)Instantiate(UnlockEffector);
            instantiatedEffector.SetActive(true);
        }
    }
}

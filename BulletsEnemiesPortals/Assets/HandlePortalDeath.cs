using UnityEngine;
using System.Collections;

public class HandlePortalDeath : MonoBehaviour {

    public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy() {
        Time.timeScale = 0;
        GameObject gameOver = new GameObject();
        gameOver.AddComponent<HandleGameOver>().gameOverMessage = "You Win!";
        gameOver.GetComponent<HandleGameOver>().skin = skin;
    }
}

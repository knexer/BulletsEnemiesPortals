using UnityEngine;
using System.Collections;

public class HandlePortalDeath : MonoBehaviour {

    private static bool isShuttingDown = false;

    public GUISkin skin;
 
    void OnApplicationQuit() {
        isShuttingDown = true;
    }

    void OnDestroy() {
        if (isShuttingDown) return;

        Time.timeScale = 0;
        GameObject gameOver = new GameObject();
        HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
        message.skin = skin;
        message.gameOverMessage = "You Win!";
    }
}

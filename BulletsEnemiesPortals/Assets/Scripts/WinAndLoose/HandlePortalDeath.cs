using UnityEngine;
using System.Collections;

public class HandlePortalDeath : MonoBehaviour {

    private static bool isShuttingDown = false;
    private static int numVotes = 0;

    public GUISkin skin;

    void Start()
    {
        numVotes++;
    }
 
    void OnApplicationQuit() {
        isShuttingDown = true;
    }

    void OnDestroy() {
        numVotes--;
        if (numVotes == 0)
        {
            if (isShuttingDown) return;

            Time.timeScale = 0;
            Screen.lockCursor = false;
            GameObject gameOver = new GameObject();
            HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
            message.skin = skin;
            message.gameOverMessage = "You Win!";
        }
    }
}

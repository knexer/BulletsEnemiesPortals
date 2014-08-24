using UnityEngine;
using System.Collections;

public class VoteForGameNotLose : MonoBehaviour {

    public GUISkin skin;

    private static bool isShuttingDown = false;
    private const int width = 400;
    private const int height = 300;

    static int numVotes = 0;

	// Use this for initialization
	void Start () {
        numVotes++;
	}

    void OnDestroy()
    {
        numVotes--;
        if (numVotes <= 0)
        {
            if (isShuttingDown) return;

            Time.timeScale = 0;
            Screen.lockCursor = false;
            GameObject gameOver = new GameObject();
            HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
            message.skin = skin;
            message.gameOverMessage = "You Loose!";
        }
    }

    void OnApplicationQuit() {
        isShuttingDown = true;
    }
}

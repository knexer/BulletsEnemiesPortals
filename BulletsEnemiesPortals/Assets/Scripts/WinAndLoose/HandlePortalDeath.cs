using UnityEngine;
using System.Collections;

public class HandlePortalDeath : MonoBehaviour {

    private static int numVotes = 0;

    public GUISkin skin;

    void Start()
    {
        numVotes++;
        gameObject.GetComponent<TakeDamage>().OnDeath += () => onDeath();
    }

    private void onDeath() {
        if (numVotes <= 1)
        {
            Time.timeScale = 0;
            Screen.lockCursor = false;
            HandleWinAndLose.instance.recordWin();
            GameObject gameOver = new GameObject();
            HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
            message.skin = skin;
            message.gameOverMessage = "You Win!";
        }
    }

    void OnDestroy()
    {
        numVotes--;
    }
}

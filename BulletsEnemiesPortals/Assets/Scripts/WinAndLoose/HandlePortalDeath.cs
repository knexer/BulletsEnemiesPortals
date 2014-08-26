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
        numVotes--;
        if (numVotes == 0)
        {
            Time.timeScale = 0;
            Screen.lockCursor = false;
            GameObject gameOver = new GameObject();
            HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
            message.skin = skin;
            message.gameOverMessage = "You Win!";
        }
    }
}

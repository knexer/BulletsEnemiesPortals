using UnityEngine;
using System.Collections;

public class VoteForGameNotLose : MonoBehaviour {

    public GUISkin skin;

    static int numVotes = 0;

	// Use this for initialization
	void Start () {
        numVotes++;
        gameObject.GetComponent<TakeDamage>().OnDeath += () => onDeath();
	}

    void onDeath()
    {
        if (numVotes <= 1)
        {
            Time.timeScale = 0;
            Screen.lockCursor = false;
            HandleWinAndLose.instance.recordLoss();
            GameObject gameOver = new GameObject();
            HandleGameOver message = gameOver.AddComponent<HandleGameOver>();
            message.skin = skin;
            message.gameOverMessage = "You Lose!";
        }
    }

    void OnDestroy()
    {
        numVotes--;
    }
}

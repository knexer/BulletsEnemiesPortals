using UnityEngine;
using System.Collections;

public class VoteForGameNotLose : MonoBehaviour {

    public GUISkin skin;

    private const int width = 400;
    private const int height = 300;

    static int numVotes = 0;
    private bool isLoose = false;

	// Use this for initialization
	void Start () {
        numVotes++;
	}

    void OnDestroy()
    {
        numVotes--;
        if (numVotes <= 0)
        {
            isLoose = true;
            Time.timeScale = 0;
        }
    }

    void OnGUI() {
        if (isLoose) {
            Debug.LogError("Showing menu");
            GUI.skin = skin;
            GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, "You Loose!");
        }
    }

    public void layoutWindow(int id) {
        GUILayout.BeginHorizontal();
        GUILayout.Space(70);
        if (GUILayout.Button("Okay")) {
            Time.timeScale = 1;
            Application.LoadLevel("MainMenu");
        }
        GUILayout.Space(70);
        GUILayout.EndHorizontal();
    }
}

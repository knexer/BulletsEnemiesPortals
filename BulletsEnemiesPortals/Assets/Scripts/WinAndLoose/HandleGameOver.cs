using UnityEngine;
using System.Collections;

public class HandleGameOver : MonoBehaviour {

    public GUISkin skin;

    private const int height = 300;
    private const int width = 400;

    public string gameOverMessage = "Game Over man! Game over!";

    void OnLevelWasLoaded() {
        Destroy(gameObject);
    }

    void OnGUI() {
        GUI.skin = skin;
        GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, gameOverMessage);
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("Okay")) {
            Time.timeScale = 1;
            Application.LoadLevel("MainMenu");
        }

        GUILayout.Space(50);
    }
}

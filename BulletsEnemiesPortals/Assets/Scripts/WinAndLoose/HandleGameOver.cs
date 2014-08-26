using UnityEngine;
using System.Collections;

public class HandleGameOver : MonoBehaviour {

    public GUISkin skin;

    private const int height = 300;
    private const int width = 400;

    public string gameOverMessage = "Game Over man! Game over!";

    private bool display = true;

    void OnGUI() {
        if (display) {
            GUI.skin = skin;
            GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, gameOverMessage);
        }
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("Okay")) {
            display = false;
            HandleNewUnlocks.instance.endLevel();
        }

        GUILayout.Space(50);
    }
}

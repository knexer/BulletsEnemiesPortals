using UnityEngine;
using System.Collections;

public class EscapeMenu : MonoBehaviour {

    public GUISkin skin;

    private bool isShow = false;

    private const int height = 550;
    private const int width = 400;

    void Start() {
        Debug.LogError("Time scale is " + Time.timeScale);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            isShow = true;
            Screen.lockCursor = false;
            Time.timeScale = 0;
        }
    }

    void OnGUI() {
        if (isShow) {
            GUI.skin = skin;
            GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, "Paused");
        }
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("Resume")) {
            isShow = false;
            Screen.lockCursor = true;
            Time.timeScale = 1;
        }

        GUILayout.Button("Unlocks");
        GUILayout.Button("Options");

        if (GUILayout.Button("Exit to Menu")) {
            Time.timeScale = 1;
            Debug.LogError("Set time scale to " + Time.timeScale);
            Application.LoadLevel("MainMenu");
        }

        if (GUILayout.Button("Exit to Desktop")) {
            Application.Quit();
        }

        GUILayout.Space(50);
    }
}

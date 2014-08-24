using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public GUISkin skin;

    private const int size = 570;

    void Start() {
        Debug.LogError("Time scale is " + Time.timeScale);
    }

    void OnGUI() {
        GUI.skin = skin;
        GUI.Window(0, new Rect((Screen.width - size) / 2, (Screen.height - size) / 2, size, size), layoutWindow, "Bullets, Enemies,\nPortals");
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        GUIStyle largeButton = new GUIStyle(skin.button);
        largeButton.fontSize = 50;
        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        if (GUILayout.Button("Play", largeButton)) {
            Application.LoadLevel("SkittlesWorld");
        }
        GUILayout.Space(100);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        GUILayout.Button("Unlocks");
        GUILayout.Space(100);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        GUILayout.Button("Options");
        GUILayout.Space(100);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        if (GUILayout.Button("Exit")) {
            Application.Quit();
        }
        GUILayout.Space(100);
        GUILayout.EndHorizontal();

        GUILayout.Space(20);
    }
}

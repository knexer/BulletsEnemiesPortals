using UnityEngine;
using System.Collections;

public class NewGameMenu : MonoBehaviour {

    public GUISkin skin;

    private const int size = 700;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
        GUILayout.Button("Play", largeButton);
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

        GUILayout.Space(100);
    }
}

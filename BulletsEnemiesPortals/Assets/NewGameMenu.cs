using UnityEngine;
using System.Collections;

public class NewGameMenu : MonoBehaviour {

    public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUI.skin = skin;
        GUI.Window(0, new Rect(200, 50, 700, 700), layoutWindow, "Bullets, Enemies,\nPortals");
    }

    public void layoutWindow(int id) {
        GUILayout.Space(100);
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.Button("Start");
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }
}

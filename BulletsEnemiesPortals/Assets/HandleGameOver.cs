﻿using UnityEngine;
using System.Collections;

public class HandleGameOver : MonoBehaviour {

    public GUISkin skin;

    private const int height = 700;
    private const int width = 400;

    public string gameOverMessage = "Game Over man! Game over!";

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUI.skin = skin;
        GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, gameOverMessage);
    }

    public void layoutWindow(int id) {
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("Exit to Menu")) {
            Time.timeScale = 1;
            Application.LoadLevel("MainMenu");
        }

        if (GUILayout.Button("Exit to Desktop")) {
            Application.Quit();
        }

        GUILayout.Space(100);
    }
}
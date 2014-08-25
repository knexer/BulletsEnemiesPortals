using UnityEngine;
using System.Collections;
using System;

public class MainMenu : MonoBehaviour {

    public GUISkin skin;

    private GUIStyle largeButton;
    private Menu[] menus;
    private int currentMenu = 0;

    private const int size = 570;

    void Start() {
        Time.timeScale = 1;
        largeButton = new GUIStyle(skin.button);
        largeButton.fontSize = 50;
        
        menus = new Menu[] {
            new Menu("Bullets, Enemies,\nPortals", mainMenu),
            new Menu("Unlocks", unlocksMenu),
            new Menu("Options", optionsMenu)
        };
    }

    void OnGUI() {
        GUI.skin = skin;
        GUI.Window(0, new Rect((Screen.width - size) / 2, (Screen.height - size) / 2, size, size), menus[currentMenu].function, menus[currentMenu].title);
    }

    public void mainMenu(int id) {
        GUILayout.FlexibleSpace();

        printButton("Play!", () => Application.LoadLevel("SkittlesWorld"), largeButton);
        printButton("Unlocks", () => currentMenu = 1);
        printButton("Options", () => currentMenu = 2);
        printButton("Exit", () => Application.Quit());

        GUILayout.Space(20);
    }

    public void unlocksMenu(int id) {
        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal();

        UnlockData[] unlocks = FindObjectsOfType<UnlockData>();
        for (int i = 0; i < unlocks.Length; i++ ) {
            UnlockData unlock = unlocks[i];
            GUIContent content = new GUIContent();
            content.text = unlock.name;
            content.image = unlock.texture;
            content.tooltip = unlock.description;

            if (i != 0 && i % 2 == 0) {
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
            }

            GUI.enabled = unlock.isUnlocked;
            unlock.isActivated = GUILayout.Toggle(unlock.isActivated, content);
            GUI.enabled = true;
        }

        GUILayout.EndHorizontal();
        GUILayout.FlexibleSpace();
        printButton("Back", () => currentMenu = 0);
    }

    public void optionsMenu(int id) {
        GUILayout.FlexibleSpace();
        printButton("Back", () => currentMenu = 0);
    }



    private void printButton(string text, Action onClick, GUIStyle style = null) {
        GUILayout.BeginHorizontal();
        GUILayout.Space(100);
        if (style == null) style = skin.button;
        if (GUILayout.Button(text, style)) {
            onClick();
        }
        GUILayout.Space(100);
        GUILayout.EndHorizontal();
    }

    private class Menu {
        public string title;
        public GUI.WindowFunction function;

        public Menu(string title, GUI.WindowFunction function) {
            this.title = title;
            this.function = function;
        }
    }
}

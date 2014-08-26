using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HandleNewUnlocks : MonoBehaviour {

    private const int height = 400;
    private const int width = 570;

    public static HandleNewUnlocks instance { get; private set; }

    public GUISkin skin;

    private List<UnlockData> newUnlocks = new List<UnlockData>();
    private int unlockIndex = -1;
    private bool increment = false;

    void Start() {
        instance = this;
    }

    public void registerUnlock(string unlockName) {
        UnlockData[] unlocks = FindObjectsOfType<UnlockData>();
        UnlockData newUnlock = null;
        foreach (UnlockData unlock in unlocks) {
            if (unlock.name.Equals(unlockName)) {
                newUnlock = unlock;
                break;
            }
        }

        if (newUnlock != null && newUnlock.isUnlocked == false) {
            newUnlocks.Add(newUnlock);
            newUnlock.isUnlocked = true;
        }
    }

    public void endLevel() {
        unlockIndex = 0;
    }

    void Update() {
        if (increment) {
            unlockIndex++;
        }
    }

    void OnGUI() {
        if (unlockIndex == -1) return;

        if (unlockIndex >= newUnlocks.Count) {
            newUnlocks = new List<UnlockData>();
            unlockIndex = -1;
            increment = false;
            Application.LoadLevel("MainMenu");
        } else {
            GUI.skin = skin;
            GUI.Window(0, new Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height), layoutWindow, "You unlocked\n" + newUnlocks[unlockIndex].name + "!");
        }
    }

    public void layoutWindow(int id) {
        GUILayout.Space(100);

        GUIContent content = new GUIContent();
        content.text = "Turn on your unlocks from the Unlocks screen on the Main Menu";
        content.image = newUnlocks[unlockIndex].texture;
        GUILayout.Label(content);

        GUILayout.FlexibleSpace();

        GUILayout.BeginHorizontal();
        GUILayout.Space(50);
        if (GUILayout.Button("Okay")) {
            increment = true;
        }
        GUILayout.Space(50);
        GUILayout.EndHorizontal();

        GUILayout.FlexibleSpace();
    }
}
